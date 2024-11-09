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
using System.Windows.Controls;

namespace WindowsFormsApp2
{
    public partial class Bloco5 : Form
    {
        public Bloco5()
        {
            InitializeComponent();

            ConfigureRichTextBoxes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o formulário
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigureRichTextBoxes()
        {
            // Lista de todos os RichTextBoxes do form
            var richTextBoxes = new[]
            {
                richTextBox1, richTextBox2, richTextBox3,
                richTextBox4, richTextBox5, richTextBox6,
                richTextBox7
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


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.saaelagoa.com.br/agua/entenda-seu-hidrometro") { UseShellExecute = true });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://web.archive.org/web/20150205131927/http://www.folhadequarai.com.br/fotos.php?id=1971") { UseShellExecute = true });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://pt.wikipedia.org/wiki/Hidr%C3%B4metro#Refer%C3%AAncias") { UseShellExecute = true });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=cIdr3-vyS9Q") { UseShellExecute = true });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=H6pzE_iLT3Q") { UseShellExecute = true });
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=AlpVsMJRLCI") { UseShellExecute = true });
        }

        private void Bloco5_Load(object sender, EventArgs e)
        {

        }
    }
}
