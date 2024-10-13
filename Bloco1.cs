using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bloco1 : Form
    {
        public Bloco1()
        {
            InitializeComponent();

            // Associar os eventos corretamente
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;


            // Limpar o RichTextBox para adicionar o texto formatado
            richTextBox1.Clear();

            // Título principal - Maior e em negrito
            richTextBox1.SelectionFont = new Font("Arial", 14, FontStyle.Bold);
            richTextBox1.AppendText("A Importância da Água e seu Papel Essencial para a Vida\n\n");

            // Texto comum - Fonte padrão
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("A água é uma substância química fundamental para a existência e a manutenção da vida no planeta Terra, este elemento é composto por duas moléculas de hidrogênio e uma de oxigênio, demonstrado na fórmula H₂O. Ela é encontrada em três estados físicos: no estado líquido, ela está presente nos rios, lagos, lençóis freáticos e principalmente nos mares e oceanos; no estado sólido ela se encontra na forma de geleiras e galopas polares, localizada nas regiões árticas e antárticas; e no estado gasoso pode ser encontrada como vapor na atmosfera terrestre.\n\n");
            richTextBox1.AppendText("Nenhum ser vivo pode sobreviver sem a água, o que a torna um dos recursos mais valiosos do mundo. Desde os organismos mais simples até os mais complexos, todos dependem dela para realizar processos metabólicos e funções biológicas essenciais para sobrevivência. No corpo humano, a água representa cerca de 60% da massa corporal, enquanto em outros organismos, como plantas e algumas formas de vida aquática, essa proporção pode superar 90%. Além de ser um componente estrutural vital, a água serve como meio para as reações químicas que sustentam a vida. A falta de água interrompe essas funções metabólicas, resultando em morte celular e, consequentemente, na falência do organismo como um todo.\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("A Composição da Vida - A Importância Biológica da Água\n\n");

            // Texto comum
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("• Transporte de Nutrientes e Eliminação de Resíduos\n");
            richTextBox1.AppendText("No corpo humano e em outros organismos, a água atua como o principal meio de transporte de nutrientes, oxigênio e outras substâncias essenciais. O sangue, composto em grande parte por água, é responsável por levar esses nutrientes para as células e remover produtos metabólicos, como o dióxido de carbono e ureia, que são eliminados do corpo por meio da respiração e urina, respectivamente.\n\n");
            richTextBox1.AppendText("Além disso, em organismos multicelulares, a água é fundamental para o transporte de hormônios e outras moléculas sinalizadoras, permitindo a comunicação entre diferentes partes do corpo. Esse transporte eficiente assegura que as células recebam os nutrientes necessários e que os resíduos sejam rapidamente removidos, prevenindo o acúmulo de toxinas.\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("• Regulação da Temperatura Corporal\n\n");

            // Texto comum
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("A água desempenha um papel na regulação da temperatura corporal, especialmente em animais de sangue quente como os humanos. Por meio da transpiração, o corpo utiliza a água para dissipar o excesso de calor. O processo de evaporação do suor na superfície da pele consome energia térmica, permitindo que o corpo se resfrie. Essa capacidade de regular a temperatura é fundamental para a homeostase, garantindo que as reações bioquímicas ocorram dentro de uma faixa de temperatura segura.\n\n");
            richTextBox1.AppendText("Em organismos aquáticos, a alta capacidade térmica da água do ambiente atua como um regulador natural, oferecendo um ambiente estável e minimizando as flutuações de temperatura que poderiam impactar negativamente a sobrevivência das espécies.\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("• Funções celulares\n\n");

            // Texto comum
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("Em nível celular, a água é responsável por a estrutura das células. Ela proporciona um meio aquoso no qual os processos bioquímicos ocorrem, facilitando o movimento de moléculas e íons entre as organelas celulares. As reações enzimáticas, fundamentais para o metabolismo celular, ocorrem em ambientes aquosos devido à natureza polar da água, que facilita a interação entre as enzimas e seus substratos.\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("Propriedades Únicas da Água\n\n");

            // Texto comum
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("Sua estrutura molecular confere-lhe a capacidade de formar pontes de hidrogênio, que influenciam suas características, como o elevado calor específico, a alta capacidade de dissolução, o ponto de ebulição elevado em comparação a outros líquidos semelhantes e sua coesão e adesão.\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("1) Elevada Capacidade de Dissolução\n\n");

            // Texto comum
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("A água é conhecida como o 'solvente universal' devido à sua capacidade de dissolver diversas substâncias, como sais, gases, proteínas e outras moléculas biológicas. A polaridade da molécula de água permite que ela envolva íons e moléculas polares, facilitando a dissolução e o transporte de nutrientes essenciais dentro dos organismos.\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("2) Água e a Fotossíntese nas Plantas\n\n");

            // Subtítulo
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("Ecossistemas e Ciclo Hidrológico\n\n");

            // Texto comum
            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("Além de sustentar a vida individual dos organismos, a água é essencial para os ecossistemas como um todo. Ela é parte integrante do ciclo hidrológico, que inclui a evaporação, condensação e precipitação. Esse ciclo garante que os sistemas naturais sejam reabastecidos com água doce, mantendo os rios, lagos, florestas e oceanos em equilíbrio. Ecossistemas aquáticos, como rios e oceanos, são habitats fundamentais para uma vasta gama de espécies, muitas das quais dependem diretamente da água para alimentação, reprodução e sobrevivência.\n\n");
            richTextBox1.AppendText("Os ecossistemas aquáticos, como rios, lagos e oceanos, dependem diretamente da água para sustentar a biodiversidade. Peixes, plantas aquáticas, algas, anfíbios e uma vasta gama de organismos marinhos fazem parte dessas cadeias ecológicas. Esses ambientes fornecem alimentos, habitat, e auxiliam na manutenção do ciclo natural da água, além de influenciar no ciclo de nutrientes essenciais, como o carbono e nitrogênio.\n\n");
            richTextBox1.AppendText("A água também desempenha um papel fundamental na regulação dos climas globais. Os oceanos atuam como grandes reguladores térmicos, absorvendo calor do sol e distribuindo-o de forma uniforme ao redor do planeta. Esse processo influencia padrões climáticos, como a formação de chuvas e tempestades, afetando diretamente as zonas terrestres e seus ecossistemas.\n\n");

            // Conclusão
            richTextBox1.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            richTextBox1.AppendText("Conclusão\n\n");

            richTextBox1.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
            richTextBox1.AppendText("A água é, sem dúvida, sustenta todas as formas de vida do planeta Terra. Suas propriedades químicas e físicas fazem dela um elemento único para a sobrevivência de todos os organismos vivos. Sua versatilidade e importância abrangem desde os níveis molecular, celular, orgânico e ecológico até as funções biológicas mais básicas nos organismos vivos, a regulação dos ecossistemas e a manutenção da sociedade humana.\n\n");
            richTextBox1.AppendText("Portanto, é imprescindível que medidas sejam tomadas para garantir o uso consciente e a preservação da água, assegurando que futuras gerações possam continuar a usufruir desse recurso tão valioso. A preservação da água é um compromisso com a vida.");

            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();
        }

        private void Bloco1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Fecha o Form2, automaticamente voltando ao Form1
            this.Close();

        }

        // Quando o mouse entra na área do PictureBox
        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Simular o efeito de destaque aumentando o PictureBox
            pictureBox1.Size = new Size(pictureBox1.Width + 10, pictureBox1.Height + 10);
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle; // Adiciona uma borda
        }

        // Quando o mouse sai da área do PictureBox
        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar o tamanho original
            pictureBox1.Size = new Size(pictureBox1.Width - 10, pictureBox1.Height - 10);
            //pictureBox1.BorderStyle = BorderStyle.None; // Remove a borda
        }
    }
}
