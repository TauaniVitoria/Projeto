using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Bloco3 : Form
    {
        public Bloco3()
        {
            InitializeComponent();


            ConfigureRichTextBoxes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bloco3_Load(object sender, EventArgs e)
        {

        }

        private void ConfigureRichTextBoxes()
        {
            // Lista de todos os RichTextBoxes do form
            var richTextBoxes = new[]
            {
            richTextBox1, richTextBox2, richTextBox3,
            richTextBox4, richTextBox5, richTextBox6,
            richTextBox7, richTextBox8, richTextBox9
        };

            foreach (var rtb in richTextBoxes)
            {
                // Desabilitar edição
                rtb.ReadOnly = true;

                // Remover o cursor e a seleção
                rtb.GotFocus += (s, e) => ActiveControl = null;

                // Configurar o cursor para que não apareça
                rtb.Cursor = Cursors.Default;

                // Definir cor de fundo como branca mesmo em ReadOnly
                rtb.BackColor = Color.White;


                // Pegar o RTF atual
                string rtfAtual = rtb.Rtf;

                // Substituir o alinhamento padrão por justificado
                rtfAtual = rtfAtual.Replace(@"\ql", @"\qj");

                // Se não encontrou \ql, adiciona \qj após cada \pard
                if (!rtfAtual.Contains(@"\qj"))
                {
                    rtfAtual = rtfAtual.Replace(@"\pard", @"\pard\qj");
                }

                // Aplicar o RTF modificado
                rtb.Rtf = rtfAtual;

                // Remove a seleção
                rtb.SelectionLength = 0;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void title2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://blog.brkambiental.com.br/identifique-vazamentos/") { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.saaegloria.mg.gov.br/como-identificar-vazamento-de-agua-em-sua-residencia#:~:text=vazamento%20de%20%C3%A1gua-,Como%20fazer%20o%20teste:,sinal%20de%20vazamento%20no%20cano") { UseShellExecute = true });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.careplus.com.br/careplus-mais/veja-11-dicas-para-evitar-o-desperdicio-de-agua-e-proteger-o-meio-ambiente ") { UseShellExecute = true });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.nestle.com.br/re/materias/7-dicas-para-reduzir-o-desperdicio-de-agua-na-sua-casa#:~:text=Quer%20saber%20como%20utilizar%20esse,e%20higienizando%20o%20vaso%20sanit%C3%A1rio") { UseShellExecute = true });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://casa.abril.com.br/bem-estar/11-dicas-para-economizar-agua/?utm_source=google&utm_medium=cpc&utm_campaign=eda_casa_audiencia_institucional-Performance-Max-nova-dois&gad_source=1&gclid=CjwKCAjwyfe4BhAWEiwAkIL8sKm-iYNlGRjZLHDnoBSvqamN4UckfFvobFVJRFRWhmK4MX42fliPXBoCGYcQAvD_BwE") { UseShellExecute = true });
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.fani.com.br/blog/redutor-de-vazao-o-que-e/") { UseShellExecute = true });
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.brkambiental.com.br/cacador/dicas-para-evitar-o-desperdicio-de-agua") { UseShellExecute = true });
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("http://blog.h2opurificadores.com.br/como-economizar-agua/?utm_source=google&utm_medium=paid&utm_campaign=21164647165&utm_content=&utm_term=&gadid=&gad_source=1&gbraid=0AAAAADj-mQJH2DpHVR3dt9Y0QczjNHFPs&gclid=CjwKCAjwyfe4BhAWEiwAkIL8sDXpqVO35rCG7U_B9Fttv98uFXkOnTv93cXnJEhre_VEsW5gFIZq6RoChH0QAvD_BwE") { UseShellExecute = true });
        }
    }
}
