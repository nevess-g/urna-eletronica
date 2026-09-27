# 🗳️ Urna Eletrônica - Windows Forms

Simulador de uma urna eletrônica de votação desenvolvido em **C# / Windows Forms**, com apuração de votos em tempo real e exibição gráfica dos resultados. O projeto utiliza os personagens da série *Chaves* como candidatos fictícios, para fins didáticos.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=flat&logo=csharp)
![Platform](https://img.shields.io/badge/platform-Windows-0078D6?style=flat&logo=windows)
![License](https://img.shields.io/badge/license-MIT-green)

## Sobre o projeto

Este projeto reproduz o funcionamento básico de uma urna eletrônica real, permitindo que o usuário digite o número de um candidato, confirme o voto (ou vote em branco/nulo) e, ao final, consulte a apuração com totais por candidato e um gráfico comparativo.

Foi desenvolvido como projeto de estudo/prática de **Windows Forms**, manipulação de eventos, `Timer`, coleções (`Dictionary`) e componentes de gráfico (`Chart`).

## Funcionalidades

- **Digitação do número do candidato** através de teclado numérico na tela (2 dígitos).
- **Exibição automática do candidato** (nome, partido e foto) ao completar o número digitado.
- **Voto nulo**, com indicação piscante quando o número digitado não corresponde a nenhum candidato.
- **Voto em branco**, com indicação piscante dedicada.
- **Confirmação de voto**, com tela de "gravando voto" (barra de progresso) e efeito sonoro ao final.
- **Correção de voto** antes da confirmação.
- **Reinício automático** da urna após alguns segundos, pronta para o próximo eleitor.
- **Painel de apuração**, exibindo:
  - Total de votos por candidato;
  - Total de votos brancos, nulos e totais;
  - Gráfico de barras comparando os votos de cada candidato.
- **Apuração do vencedor**, com tratamento de empate entre candidatos.

## 🗳️ Candidatos

| Número | Nome         | Partido               |
|--------|--------------|------------------------|
| 11     | Chaves       | Sanduíche de Presunto |
| 12     | Sr. Barriga  | Inquilinos             |
| 13     | D. Florinda  | Gentalha               |
| 14     | Kiko         | Bola Quadrada          |
| 15     | Chiquinha    | Confusão                |

## Tecnologias utilizadas

- [C#](https://learn.microsoft.com/dotnet/csharp/)
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- [Windows Forms](https://learn.microsoft.com/dotnet/desktop/winforms/)
- `System.Windows.Forms.DataVisualization.Charting` — geração do gráfico de apuração
- `System.Media.SoundPlayer` — reprodução do som de confirmação de voto

## Estrutura do projeto

```
Projeto 14 - Urna/
├── Form1.cs                     # Lógica principal da urna (eventos, votação, apuração)
├── Form1.Designer.cs            # Layout e componentes visuais gerados pelo Designer
├── Program.cs                   # Ponto de entrada da aplicação
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx           # Imagens e sons embutidos
│   └── Settings.settings
├── Resources/
│   ├── chaves.png / chaves.bmp
│   ├── barriga.jpg
│   ├── florinda.jpg
│   ├── kiko.jpg
│   ├── chiquinha.jpg
│   └── urna.wav                 # Som de confirmação do voto
├── App.config
└── Projeto 14 - Urna.csproj
```

## Como executar

### Pré-requisitos

- Windows 10/11
- [Visual Studio 2019](https://visualstudio.microsoft.com/) ou superior (com a carga de trabalho **Desenvolvimento para desktop com .NET**)
- .NET Framework 4.7.2 (Developer Pack)

### Passo a passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/nevess-g/urna-eletronica.git
   ```
2. Abra o arquivo `Projeto 14 - Urna.sln` no Visual Studio.
3. Restaure as dependências/pacotes (o Visual Studio faz isso automaticamente ao abrir a solução).
4. Pressione `F5` (ou clique em **Iniciar**) para compilar e executar o projeto.

## Como usar

1. Digite o número do candidato (2 dígitos) usando o teclado numérico exibido na tela.
2. Confira o nome, partido e foto do candidato exibidos.
3. Clique em **Confirma** para registrar o voto, ou em **Corrige** para apagar e digitar novamente.
4. Caso não digite nenhum número e confirme, o voto será contabilizado como **branco**.
5. Números que não correspondem a nenhum candidato são contabilizados como **nulo**.
6. Ao final da votação, clique em **Exibir Apuração** para ver o total de votos, o gráfico comparativo e, em seguida, em **Ganhador** para saber o resultado final (ou se houve empate).

## Possíveis melhorias futuras

- [ ] Persistência dos votos em banco de dados ou arquivo, evitando perda ao fechar a aplicação.
- [ ] Cadastro dinâmico de candidatos (ao invés de lista fixa no código).
- [ ] Exportação do resultado da apuração (PDF/Excel).


