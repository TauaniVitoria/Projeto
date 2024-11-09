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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();

        }

        private void Creditos_Load(object sender, EventArgs e)
        {
            // Configurar o RichTextBox
            richTextBox1.Clear();

            // Adicionar o título da disciplina com formatação em negrito
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Bahnschrift", 16, FontStyle.Bold); // Aumentar o tamanho da fonte
            richTextBox1.AppendText("Disciplina: Programação de Computadores\n\n");


            // Nome do professor
            richTextBox1.SelectionFont = new Font("Bahnschrift", 16, FontStyle.Bold);
            richTextBox1.AppendText("Nome do professor: ");
            richTextBox1.SelectionFont = new Font("Bahnschrift", 16, FontStyle.Regular);
            richTextBox1.AppendText("Prof. Dr. Elvio Gilberto da Silva.\n\n");

           
            // Integrantes da equipe
            richTextBox1.SelectionFont = new Font("Bahnschrift", 16, FontStyle.Bold);
            richTextBox1.AppendText("Integrantes da equipe:\n");
            richTextBox1.SelectionFont = new Font("Bahnschrift", 16, FontStyle.Regular);
            richTextBox1.AppendText("Jhuliani Cristina Amorim dos Santos\n");
            richTextBox1.SelectionFont = new Font("Bahnschrift", 16, FontStyle.Regular);
            richTextBox1.AppendText("Tauani Vitória Ferreira\n");

            richTextBox1.SelectionStart = 0;
            richTextBox1.ScrollToCaret();

            // Remover o cursor e a seleção
            richTextBox1.GotFocus += (s, b) => ActiveControl = null;

            // Configurar o cursor para que não apareça
            richTextBox1.Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
