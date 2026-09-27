
namespace Projeto_14___Urna
{
    partial class Urna
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urna));
            this.brancoButton = new System.Windows.Forms.Button();
            this.corrigeButton = new System.Windows.Forms.Button();
            this.confirmaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.brancoLabel = new System.Windows.Forms.Label();
            this.nuloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.D2textBox = new System.Windows.Forms.TextBox();
            this.D1textBox = new System.Windows.Forms.TextBox();
            this.panelCandidato = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.candidatopictureBox = new System.Windows.Forms.PictureBox();
            this.partidoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n2textBox = new System.Windows.Forms.TextBox();
            this.n1textBox = new System.Windows.Forms.TextBox();
            this.gravandoPanel = new System.Windows.Forms.Panel();
            this.gravandoLabel = new System.Windows.Forms.Label();
            this.gravandoprogressBar = new System.Windows.Forms.ProgressBar();
            this.fimPanel = new System.Windows.Forms.Panel();
            this.fimLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.timerGravando = new System.Windows.Forms.Timer(this.components);
            this.resultadoButton = new System.Windows.Forms.Button();
            this.apuracaoPanel = new System.Windows.Forms.Panel();
            this.ganhadorButton = new System.Windows.Forms.Button();
            this.kikoLabel = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.totaisLabel = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.nulosLabel = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.votosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.brancosLabel = new System.Windows.Forms.Label();
            this.barrigaLabel = new System.Windows.Forms.Label();
            this.florindaLabel = new System.Windows.Forms.Label();
            this.chiquinhaLabel = new System.Windows.Forms.Label();
            this.chavesLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatopictureBox)).BeginInit();
            this.gravandoPanel.SuspendLayout();
            this.fimPanel.SuspendLayout();
            this.apuracaoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votosChart)).BeginInit();
            this.SuspendLayout();
            // 
            // brancoButton
            // 
            this.brancoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brancoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brancoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brancoButton.Location = new System.Drawing.Point(845, 611);
            this.brancoButton.Name = "brancoButton";
            this.brancoButton.Size = new System.Drawing.Size(104, 55);
            this.brancoButton.TabIndex = 2;
            this.brancoButton.Text = "BRANCO";
            this.brancoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brancoButton.UseVisualStyleBackColor = true;
            this.brancoButton.Click += new System.EventHandler(this.brancoButton_Click);
            // 
            // corrigeButton
            // 
            this.corrigeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.corrigeButton.BackColor = System.Drawing.Color.OrangeRed;
            this.corrigeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.corrigeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corrigeButton.Location = new System.Drawing.Point(966, 611);
            this.corrigeButton.Name = "corrigeButton";
            this.corrigeButton.Size = new System.Drawing.Size(100, 55);
            this.corrigeButton.TabIndex = 22;
            this.corrigeButton.Text = "CORRIGE";
            this.corrigeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.corrigeButton.UseVisualStyleBackColor = false;
            this.corrigeButton.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // confirmaButton
            // 
            this.confirmaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmaButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmaButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.confirmaButton.Location = new System.Drawing.Point(1088, 601);
            this.confirmaButton.Name = "confirmaButton";
            this.confirmaButton.Size = new System.Drawing.Size(99, 65);
            this.confirmaButton.TabIndex = 23;
            this.confirmaButton.Text = "CONFIRMA";
            this.confirmaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmaButton.UseVisualStyleBackColor = false;
            this.confirmaButton.Click += new System.EventHandler(this.confirmaButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(878, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 53);
            this.button1.TabIndex = 31;
            this.button1.Text = "1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.brancoLabel);
            this.panel1.Controls.Add(this.nuloLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.D2textBox);
            this.panel1.Controls.Add(this.D1textBox);
            this.panel1.Location = new System.Drawing.Point(54, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 399);
            this.panel1.TabIndex = 24;
            // 
            // brancoLabel
            // 
            this.brancoLabel.AutoSize = true;
            this.brancoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brancoLabel.Location = new System.Drawing.Point(162, 189);
            this.brancoLabel.Name = "brancoLabel";
            this.brancoLabel.Size = new System.Drawing.Size(432, 65);
            this.brancoLabel.TabIndex = 42;
            this.brancoLabel.Text = "VOTO EM BRANCO";
            this.brancoLabel.Visible = false;
            // 
            // nuloLabel
            // 
            this.nuloLabel.AutoSize = true;
            this.nuloLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuloLabel.Location = new System.Drawing.Point(240, 330);
            this.nuloLabel.Name = "nuloLabel";
            this.nuloLabel.Size = new System.Drawing.Size(263, 60);
            this.nuloLabel.TabIndex = 41;
            this.nuloLabel.Text = "VOTO NULO";
            this.nuloLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 48);
            this.label1.TabIndex = 25;
            this.label1.Text = "Presidente";
            // 
            // D2textBox
            // 
            this.D2textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.D2textBox.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2textBox.Location = new System.Drawing.Point(218, 180);
            this.D2textBox.Multiline = true;
            this.D2textBox.Name = "D2textBox";
            this.D2textBox.ReadOnly = true;
            this.D2textBox.Size = new System.Drawing.Size(75, 89);
            this.D2textBox.TabIndex = 26;
            this.D2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // D1textBox
            // 
            this.D1textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.D1textBox.Font = new System.Drawing.Font("Segoe UI", 45F);
            this.D1textBox.Location = new System.Drawing.Point(123, 180);
            this.D1textBox.Multiline = true;
            this.D1textBox.Name = "D1textBox";
            this.D1textBox.ReadOnly = true;
            this.D1textBox.Size = new System.Drawing.Size(75, 89);
            this.D1textBox.TabIndex = 27;
            this.D1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelCandidato
            // 
            this.panelCandidato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCandidato.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCandidato.BackColor = System.Drawing.Color.White;
            this.panelCandidato.Controls.Add(this.label7);
            this.panelCandidato.Controls.Add(this.candidatopictureBox);
            this.panelCandidato.Controls.Add(this.partidoLabel);
            this.panelCandidato.Controls.Add(this.nameLabel);
            this.panelCandidato.Controls.Add(this.label5);
            this.panelCandidato.Controls.Add(this.label4);
            this.panelCandidato.Controls.Add(this.label6);
            this.panelCandidato.Controls.Add(this.label3);
            this.panelCandidato.Controls.Add(this.label2);
            this.panelCandidato.Controls.Add(this.n2textBox);
            this.panelCandidato.Controls.Add(this.n1textBox);
            this.panelCandidato.Location = new System.Drawing.Point(54, 259);
            this.panelCandidato.Name = "panelCandidato";
            this.panelCandidato.Size = new System.Drawing.Size(732, 399);
            this.panelCandidato.TabIndex = 28;
            this.panelCandidato.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(581, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "Presidente";
            // 
            // candidatopictureBox
            // 
            this.candidatopictureBox.Location = new System.Drawing.Point(540, 3);
            this.candidatopictureBox.Name = "candidatopictureBox";
            this.candidatopictureBox.Size = new System.Drawing.Size(189, 209);
            this.candidatopictureBox.TabIndex = 29;
            this.candidatopictureBox.TabStop = false;
            // 
            // partidoLabel
            // 
            this.partidoLabel.AutoSize = true;
            this.partidoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partidoLabel.Location = new System.Drawing.Point(130, 352);
            this.partidoLabel.Name = "partidoLabel";
            this.partidoLabel.Size = new System.Drawing.Size(45, 32);
            this.partidoLabel.TabIndex = 37;
            this.partidoLabel.Text = "---";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(130, 305);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 32);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Partido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "SEU VOTO PARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 48);
            this.label2.TabIndex = 25;
            this.label2.Text = "Presidente";
            // 
            // n2textBox
            // 
            this.n2textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n2textBox.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2textBox.Location = new System.Drawing.Point(218, 180);
            this.n2textBox.Multiline = true;
            this.n2textBox.Name = "n2textBox";
            this.n2textBox.ReadOnly = true;
            this.n2textBox.Size = new System.Drawing.Size(75, 89);
            this.n2textBox.TabIndex = 26;
            this.n2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n1textBox
            // 
            this.n1textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n1textBox.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1textBox.Location = new System.Drawing.Point(123, 180);
            this.n1textBox.Multiline = true;
            this.n1textBox.Name = "n1textBox";
            this.n1textBox.ReadOnly = true;
            this.n1textBox.Size = new System.Drawing.Size(75, 89);
            this.n1textBox.TabIndex = 27;
            this.n1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gravandoPanel
            // 
            this.gravandoPanel.BackColor = System.Drawing.Color.White;
            this.gravandoPanel.Controls.Add(this.gravandoLabel);
            this.gravandoPanel.Controls.Add(this.gravandoprogressBar);
            this.gravandoPanel.Location = new System.Drawing.Point(54, 259);
            this.gravandoPanel.Name = "gravandoPanel";
            this.gravandoPanel.Size = new System.Drawing.Size(732, 399);
            this.gravandoPanel.TabIndex = 43;
            this.gravandoPanel.Visible = false;
            // 
            // gravandoLabel
            // 
            this.gravandoLabel.AutoSize = true;
            this.gravandoLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravandoLabel.Location = new System.Drawing.Point(291, 272);
            this.gravandoLabel.Name = "gravandoLabel";
            this.gravandoLabel.Size = new System.Drawing.Size(166, 45);
            this.gravandoLabel.TabIndex = 1;
            this.gravandoLabel.Text = "Gravando";
            // 
            // gravandoprogressBar
            // 
            this.gravandoprogressBar.ForeColor = System.Drawing.Color.Lime;
            this.gravandoprogressBar.Location = new System.Drawing.Point(62, 194);
            this.gravandoprogressBar.Name = "gravandoprogressBar";
            this.gravandoprogressBar.Size = new System.Drawing.Size(611, 33);
            this.gravandoprogressBar.TabIndex = 0;
            // 
            // fimPanel
            // 
            this.fimPanel.BackColor = System.Drawing.Color.White;
            this.fimPanel.Controls.Add(this.fimLabel);
            this.fimPanel.Location = new System.Drawing.Point(54, 259);
            this.fimPanel.Name = "fimPanel";
            this.fimPanel.Size = new System.Drawing.Size(732, 399);
            this.fimPanel.TabIndex = 42;
            this.fimPanel.Visible = false;
            // 
            // fimLabel
            // 
            this.fimLabel.AutoSize = true;
            this.fimLabel.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fimLabel.Location = new System.Drawing.Point(258, 139);
            this.fimLabel.Name = "fimLabel";
            this.fimLabel.Size = new System.Drawing.Size(199, 120);
            this.fimLabel.TabIndex = 0;
            this.fimLabel.Text = "FIM";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(975, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 53);
            this.button2.TabIndex = 32;
            this.button2.Text = "2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1072, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 53);
            this.button3.TabIndex = 33;
            this.button3.Text = "3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.AutoEllipsis = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1072, 401);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 53);
            this.button6.TabIndex = 36;
            this.button6.Text = "6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(975, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 53);
            this.button5.TabIndex = 35;
            this.button5.Text = "5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(878, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 53);
            this.button4.TabIndex = 34;
            this.button4.Text = "4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(1072, 475);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 53);
            this.button9.TabIndex = 39;
            this.button9.Text = "9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(975, 475);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 53);
            this.button8.TabIndex = 38;
            this.button8.Text = "8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(878, 475);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 53);
            this.button7.TabIndex = 37;
            this.button7.Text = "7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button0
            // 
            this.button0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(975, 543);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(82, 53);
            this.button0.TabIndex = 40;
            this.button0.Text = "0";
            this.button0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // timerGravando
            // 
            this.timerGravando.Tick += new System.EventHandler(this.timerGravando_Tick);
            // 
            // resultadoButton
            // 
            this.resultadoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoButton.Location = new System.Drawing.Point(54, 677);
            this.resultadoButton.Name = "resultadoButton";
            this.resultadoButton.Size = new System.Drawing.Size(171, 32);
            this.resultadoButton.TabIndex = 44;
            this.resultadoButton.Text = "Exibir Apuração";
            this.resultadoButton.UseVisualStyleBackColor = true;
            this.resultadoButton.Click += new System.EventHandler(this.resultadoButton_Click);
            // 
            // apuracaoPanel
            // 
            this.apuracaoPanel.BackColor = System.Drawing.Color.White;
            this.apuracaoPanel.Controls.Add(this.ganhadorButton);
            this.apuracaoPanel.Controls.Add(this.kikoLabel);
            this.apuracaoPanel.Controls.Add(this.label83);
            this.apuracaoPanel.Controls.Add(this.totaisLabel);
            this.apuracaoPanel.Controls.Add(this.label82);
            this.apuracaoPanel.Controls.Add(this.nulosLabel);
            this.apuracaoPanel.Controls.Add(this.label81);
            this.apuracaoPanel.Controls.Add(this.votosChart);
            this.apuracaoPanel.Controls.Add(this.brancosLabel);
            this.apuracaoPanel.Controls.Add(this.barrigaLabel);
            this.apuracaoPanel.Controls.Add(this.florindaLabel);
            this.apuracaoPanel.Controls.Add(this.chiquinhaLabel);
            this.apuracaoPanel.Controls.Add(this.chavesLabel);
            this.apuracaoPanel.Controls.Add(this.label13);
            this.apuracaoPanel.Controls.Add(this.label12);
            this.apuracaoPanel.Controls.Add(this.label11);
            this.apuracaoPanel.Controls.Add(this.label10);
            this.apuracaoPanel.Controls.Add(this.label9);
            this.apuracaoPanel.Controls.Add(this.label8);
            this.apuracaoPanel.Location = new System.Drawing.Point(54, 259);
            this.apuracaoPanel.Name = "apuracaoPanel";
            this.apuracaoPanel.Size = new System.Drawing.Size(732, 399);
            this.apuracaoPanel.TabIndex = 45;
            this.apuracaoPanel.Visible = false;
            // 
            // ganhadorButton
            // 
            this.ganhadorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ganhadorButton.Location = new System.Drawing.Point(577, 339);
            this.ganhadorButton.Name = "ganhadorButton";
            this.ganhadorButton.Size = new System.Drawing.Size(131, 47);
            this.ganhadorButton.TabIndex = 18;
            this.ganhadorButton.Text = "Resultado";
            this.ganhadorButton.UseVisualStyleBackColor = true;
            this.ganhadorButton.Click += new System.EventHandler(this.ganhadorButton_Click);
            // 
            // kikoLabel
            // 
            this.kikoLabel.AutoSize = true;
            this.kikoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kikoLabel.Location = new System.Drawing.Point(82, 231);
            this.kikoLabel.Name = "kikoLabel";
            this.kikoLabel.Size = new System.Drawing.Size(36, 28);
            this.kikoLabel.TabIndex = 17;
            this.kikoLabel.Text = "---";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(20, 351);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(132, 28);
            this.label83.TabIndex = 16;
            this.label83.Text = "Votos Totais:";
            // 
            // totaisLabel
            // 
            this.totaisLabel.AutoSize = true;
            this.totaisLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaisLabel.Location = new System.Drawing.Point(159, 351);
            this.totaisLabel.Name = "totaisLabel";
            this.totaisLabel.Size = new System.Drawing.Size(36, 28);
            this.totaisLabel.TabIndex = 15;
            this.totaisLabel.Text = "---";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(20, 311);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(131, 28);
            this.label82.TabIndex = 14;
            this.label82.Text = "Votos Nulos:";
            // 
            // nulosLabel
            // 
            this.nulosLabel.AutoSize = true;
            this.nulosLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nulosLabel.Location = new System.Drawing.Point(159, 311);
            this.nulosLabel.Name = "nulosLabel";
            this.nulosLabel.Size = new System.Drawing.Size(36, 28);
            this.nulosLabel.TabIndex = 13;
            this.nulosLabel.Text = "---";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(20, 271);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(151, 28);
            this.label81.TabIndex = 12;
            this.label81.Text = "Votos Brancos:";
            // 
            // votosChart
            // 
            chartArea1.Name = "ChartArea1";
            this.votosChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.votosChart.Legends.Add(legend1);
            this.votosChart.Location = new System.Drawing.Point(323, 93);
            this.votosChart.Name = "votosChart";
            this.votosChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Votos";
            this.votosChart.Series.Add(series1);
            this.votosChart.Size = new System.Drawing.Size(350, 254);
            this.votosChart.TabIndex = 11;
            this.votosChart.Text = "chart1";
            // 
            // brancosLabel
            // 
            this.brancosLabel.AutoSize = true;
            this.brancosLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brancosLabel.Location = new System.Drawing.Point(164, 274);
            this.brancosLabel.Name = "brancosLabel";
            this.brancosLabel.Size = new System.Drawing.Size(36, 28);
            this.brancosLabel.TabIndex = 10;
            this.brancosLabel.Text = "---";
            // 
            // barrigaLabel
            // 
            this.barrigaLabel.AutoSize = true;
            this.barrigaLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barrigaLabel.Location = new System.Drawing.Point(132, 195);
            this.barrigaLabel.Name = "barrigaLabel";
            this.barrigaLabel.Size = new System.Drawing.Size(36, 28);
            this.barrigaLabel.TabIndex = 9;
            this.barrigaLabel.Text = "---";
            // 
            // florindaLabel
            // 
            this.florindaLabel.AutoSize = true;
            this.florindaLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.florindaLabel.Location = new System.Drawing.Point(135, 152);
            this.florindaLabel.Name = "florindaLabel";
            this.florindaLabel.Size = new System.Drawing.Size(36, 28);
            this.florindaLabel.TabIndex = 8;
            this.florindaLabel.Text = "---";
            // 
            // chiquinhaLabel
            // 
            this.chiquinhaLabel.AutoSize = true;
            this.chiquinhaLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiquinhaLabel.Location = new System.Drawing.Point(132, 111);
            this.chiquinhaLabel.Name = "chiquinhaLabel";
            this.chiquinhaLabel.Size = new System.Drawing.Size(36, 28);
            this.chiquinhaLabel.TabIndex = 7;
            this.chiquinhaLabel.Text = "---";
            // 
            // chavesLabel
            // 
            this.chavesLabel.AutoSize = true;
            this.chavesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chavesLabel.Location = new System.Drawing.Point(105, 73);
            this.chavesLabel.Name = "chavesLabel";
            this.chavesLabel.Size = new System.Drawing.Size(36, 28);
            this.chavesLabel.TabIndex = 6;
            this.chavesLabel.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 28);
            this.label13.TabIndex = 5;
            this.label13.Text = "Kiko:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 28);
            this.label12.TabIndex = 4;
            this.label12.Text = "Sr. Barriga:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 28);
            this.label11.TabIndex = 3;
            this.label11.Text = "D. Florinda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Chiquinha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chaves:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 54);
            this.label8.TabIndex = 0;
            this.label8.Text = "Apuração Final";
            // 
            // Urna
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Projeto_14___Urna.Properties.Resources.Remove_background_project;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 735);
            this.Controls.Add(this.apuracaoPanel);
            this.Controls.Add(this.resultadoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fimPanel);
            this.Controls.Add(this.panelCandidato);
            this.Controls.Add(this.gravandoPanel);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmaButton);
            this.Controls.Add(this.corrigeButton);
            this.Controls.Add(this.brancoButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Urna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação - Chaves";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCandidato.ResumeLayout(false);
            this.panelCandidato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatopictureBox)).EndInit();
            this.gravandoPanel.ResumeLayout(false);
            this.gravandoPanel.PerformLayout();
            this.fimPanel.ResumeLayout(false);
            this.fimPanel.PerformLayout();
            this.apuracaoPanel.ResumeLayout(false);
            this.apuracaoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votosChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brancoButton;
        private System.Windows.Forms.Button corrigeButton;
        private System.Windows.Forms.Button confirmaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox D2textBox;
        private System.Windows.Forms.TextBox D1textBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label nuloLabel;
        private System.Windows.Forms.Panel gravandoPanel;
        private System.Windows.Forms.Label gravandoLabel;
        private System.Windows.Forms.ProgressBar gravandoprogressBar;
        private System.Windows.Forms.Timer timerGravando;
        private System.Windows.Forms.Panel panelCandidato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox candidatopictureBox;
        private System.Windows.Forms.Label partidoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n2textBox;
        private System.Windows.Forms.TextBox n1textBox;
        private System.Windows.Forms.Label fimLabel;
        private System.Windows.Forms.Panel fimPanel;
        private System.Windows.Forms.Button resultadoButton;
        private System.Windows.Forms.Label brancoLabel;
        private System.Windows.Forms.Panel apuracaoPanel;
        private System.Windows.Forms.Label brancosLabel;
        private System.Windows.Forms.Label barrigaLabel;
        private System.Windows.Forms.Label florindaLabel;
        private System.Windows.Forms.Label chiquinhaLabel;
        private System.Windows.Forms.Label chavesLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart votosChart;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label totaisLabel;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label nulosLabel;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label kikoLabel;
        private System.Windows.Forms.Button ganhadorButton;
    }
}

