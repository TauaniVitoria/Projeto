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
    public partial class Bloco01 : Form
    {
        public Bloco01()
        {
            InitializeComponent();

            // Configurar todos os RichTextBoxes
            ConfigureRichTextBoxes();

            this.AutoScrollPosition = new Point(0, 0);


        }

        private void ConfigureRichTextBoxes()
        {
            // Lista de todos os RichTextBoxes do form
            var richTextBoxes = new[]
            {
            richTextBox1, richTextBox2, richTextBox3,
            richTextBox4, richTextBox5, richTextBox6
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

        private void Bloco01_Load(object sender, EventArgs e)
        {
           
            
        }


        // Fecha o form, voltando para form1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://pt.wikipedia.org/wiki/%C3%81gua"){ UseShellExecute = true});
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://semil.sp.gov.br/educacaoambiental/prateleira-ambiental/agua/") { UseShellExecute = true });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://institucional.ufrrj.br/casst/a-importancia-de-beber-agua-regularmente/#:~:text=A%20%C3%A1gua%20%C3%A9%20uma%20subst%C3%A2ncia,ingerida%20regularmente%20para%20haver%20hidrata%C3%A7%C3%A3o") { UseShellExecute = true });
        }
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://mundoeducacao.uol.com.br/biologia/a-agua-como-reguladora-temperatura.htm") { UseShellExecute = true });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://mundoeducacao.uol.com.br/biologia/funcoes-agua-no-corpo-humano.htm#:~:text=A%20%C3%A1gua%20tamb%C3%A9m%20%C3%A9%20um,os%20locais%20de%20sua%20elimina%C3%A7%C3%A3o") { UseShellExecute = true });
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://mundoeducacao.uol.com.br/biologia/a-agua-como-solvente.htm#:~:text=Assim%20sendo%2C%20h%C3%A1%20anula%C3%A7%C3%A3o%20das,%C3%A1gua%20s%C3%A3o%20chamadas%20de%20hidrof%C3%ADlicas") { UseShellExecute = true });
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.todamateria.com.br/agua/") { UseShellExecute = true });
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://brasilescola.uol.com.br/biologia/ciclo-agua.htm") { UseShellExecute = true });
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.bbc.com/portuguese/internacional-59171088") { UseShellExecute = true });
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
