using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Projeto_14___Urna
{
    public partial class Urna : Form
    {
        public class Candidato
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Partido { get; set; }
            public Image Foto { get; set; }
        }

        private Dictionary<string, Candidato> _dicCanditado;
        private Dictionary<string, int> votos = new Dictionary<string, int>();
        private string numeroDigitado = "";
        private int votosNulos = 0;
        private int votosBrancos = 0;
        private int votosTotais = 0;
        private Timer reiniciarTimer;
        private Timer timerPiscarNulo;
        private Timer timerPiscarBranco;


        public Urna()
        {
            InitializeComponent();
            _dicCanditado = new Dictionary<string, Candidato>();
            _dicCanditado.Add("11", new Candidato() { Id = 11, Nome = "Chaves", Partido = "Sanduíche de Presunto", Foto = Properties.Resources.chaves });
            _dicCanditado.Add("12", new Candidato() { Id = 12, Nome = "Sr. Barriga", Partido = "Inquilinos", Foto = Properties.Resources.barriga });
            _dicCanditado.Add("13", new Candidato() { Id = 13, Nome = "D. Florinda", Partido = "Gentalha", Foto = Properties.Resources.florinda });
            _dicCanditado.Add("14", new Candidato() { Id = 14, Nome = "Kiko", Partido = "Bola Quadrada", Foto = Properties.Resources.kiko });
            _dicCanditado.Add("15", new Candidato() { Id = 15, Nome = "Chiquinha", Partido = "Confusão", Foto = Properties.Resources.chiquinha });

        }

        private void Numero_Click(object sender, EventArgs e)
        {
            if (numeroDigitado.Length >= 2) return;

            Button botao = (Button)sender;
            numeroDigitado += botao.Text;

            if (numeroDigitado.Length == 1)
            {
                D1textBox.Text = botao.Text;
                n1textBox.Text = botao.Text;
            }
            else
            {
                D2textBox.Text = botao.Text;
                n2textBox.Text = botao.Text;
            }
            if (numeroDigitado.Length == 2)
                VerificarCandidato();
        }

        private void VerificarCandidato()
        {
            if (_dicCanditado.ContainsKey(numeroDigitado))
            {
                var candidato = _dicCanditado[numeroDigitado];
                panelCandidato.Visible = true;
                panel1.Visible = false;

                nameLabel.Text = candidato.Nome;
                partidoLabel.Text = candidato.Partido;
                candidatopictureBox.Image = candidato.Foto;
            }
            else
            {
                panelCandidato.Visible = false;
                panel1.Visible = true;
                IniciarPiscarNulo();
            }
        }

        private void IniciarPiscarNulo()
        {
            if (timerPiscarNulo == null)
            {
                timerPiscarNulo = new Timer();
                timerPiscarNulo.Interval = 500;
                timerPiscarNulo.Tick += (s, e) => nuloLabel.Visible = !nuloLabel.Visible;
            }
            timerPiscarNulo.Start();
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            ReiniciarVotacao();
        }

        private void confirmaButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeroDigitado))
            {
                votosBrancos++;
            }
            else if (_dicCanditado.ContainsKey(numeroDigitado))
            {
                if (!votos.ContainsKey(numeroDigitado))
                    votos[numeroDigitado] = 0;

                votos[numeroDigitado]++;
            }
            else
            {
                votosNulos++;
            }
            panelCandidato.Visible = false;
            panel1.Visible = false;
            votosTotais++;
            IniciarGravacao();
        }

        private void brancoButton_Click(object sender, EventArgs e)
        {
            if (timerPiscarBranco == null)
            {
                timerPiscarBranco = new Timer();
                timerPiscarBranco.Interval = 500;
                timerPiscarBranco.Tick += (s1, e1) => brancoLabel.Visible = !brancoLabel.Visible;
            }
            timerPiscarBranco.Start();
            D1textBox.Visible = false;
            D2textBox.Visible = false;

        }

        private int progresso = 0;
        private void IniciarGravacao()
        {
            gravandoPanel.Visible = true;
            gravandoprogressBar.Value = 0;
            progresso = 0;
            timerGravando.Interval = 100;
            timerGravando.Start();
        }

        private void timerGravando_Tick(object sender, EventArgs e)
        {
            progresso += 10;
            if (progresso <= 100)
            {
                gravandoprogressBar.Value = progresso;
            }

            if (progresso >= 100)
            {
                timerGravando.Stop();
                gravandoPanel.Visible = false;
                fimPanel.Visible = true;
                SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
                s.Play();
            }

            if (reiniciarTimer == null)
            {
                reiniciarTimer = new Timer();
                reiniciarTimer.Interval = 3500;
                reiniciarTimer.Tick += (s2, e2) => ReiniciarVotacao();
            }
            reiniciarTimer.Start();
        }

        private void ReiniciarVotacao()
        {
            reiniciarTimer?.Stop();
            numeroDigitado = "";
            D1textBox.Text = "";
            D2textBox.Text = "";
            n1textBox.Text = "";
            n2textBox.Text = "";
            D1textBox.Visible = true;
            D2textBox.Visible = true;
            fimPanel.Visible = false;
            gravandoPanel.Visible = false;
            panelCandidato.Visible = false;
            nuloLabel.Visible = false;
            brancoLabel.Visible = false;
            panel1.Visible = true;
            timerPiscarNulo?.Stop();
            timerPiscarBranco?.Stop();
        }

        private void resultadoButton_Click(object sender, EventArgs e)
        {
            if (apuracaoPanel.Visible == true)
            {
                apuracaoPanel.Visible = false;
                resultadoButton.Text = "Exibir Apuração";
            }
            else
            {
                apuracaoPanel.Visible = true;
                resultadoButton.Text = "Fechar Apuração";
            }
            

            foreach (var item in votos)
            {
                if (_dicCanditado.TryGetValue(item.Key, out var candidato))
                {
                    switch (candidato.Nome)
                    {
                        case "Chaves":
                            chavesLabel.Text = item.Value.ToString();
                            break;
                        case "Sr. Barriga":
                            barrigaLabel.Text = item.Value.ToString();
                            break;
                        case "D. Florinda":
                            florindaLabel.Text = item.Value.ToString();
                            break;
                        case "Kiko":
                            kikoLabel.Text = item.Value.ToString();
                            break;
                        case "Chiquinha":
                            chiquinhaLabel.Text = item.Value.ToString();
                            break;
                    }
                }
            }

            votosChart.Series[0].Points.Clear();
            foreach (var item in votos)
            {
                if (_dicCanditado.TryGetValue(item.Key, out var candidato))
                {
                    votosChart.Series[0].Points.AddXY(candidato.Nome, item.Value);
                }
                else
                {
                    votosChart.Series[0].Points.AddXY("Nº " + item.Key, item.Value);
                }
            }

            brancosLabel.Text = votosBrancos.ToString();
            totaisLabel.Text = votosTotais.ToString();
            nulosLabel.Text = votosNulos.ToString();
        }
        private void ganhadorButton_Click(object sender, EventArgs e)
        {
            if (votos.Count == 0 && votosNulos == 0 && votosBrancos == 0)
            {
                MessageBox.Show("Nenhum voto foi computado ainda.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int votos11 = votos.ContainsKey("11") ? votos["11"] : 0;
            int votos12 = votos.ContainsKey("12") ? votos["12"] : 0;
            int votos13 = votos.ContainsKey("13") ? votos["13"] : 0;
            int votos14 = votos.ContainsKey("14") ? votos["14"] : 0;
            int votos15 = votos.ContainsKey("15") ? votos["15"] : 0;

            int maior = Math.Max(votos11, Math.Max(votos12, Math.Max(votos13, Math.Max(votos14, votos15))));
            string vencedor = "";

            int empateCount = 0;

            if (votos11 == maior) { vencedor = "Chaves"; empateCount++; }
            if (votos12 == maior) { vencedor = "Sr. Barriga"; empateCount++; }
            if (votos13 == maior) { vencedor = "D. Florinda"; empateCount++; }
            if (votos14 == maior) { vencedor = "Kiko"; empateCount++; }
            if (votos15 == maior) { vencedor = "Chiquinha"; empateCount++; }

            if (empateCount == 1)
            {
                MessageBox.Show($"O vencedor é {vencedor} com {maior} voto(s).", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Houve um empate com {maior} voto(s) entre {empateCount} candidato(s).", "Resultado Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
