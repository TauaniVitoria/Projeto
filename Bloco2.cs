using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bloco2 : Form
    {
        public Bloco2()
        {
            InitializeComponent();

           

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Fecha o Form2, automaticamente voltando ao Form1
            this.Close();
        }

        private void Bloco2_Load(object sender, EventArgs e)
        {
            ConfigureRichTextBoxes();
        }

        private void title0_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
