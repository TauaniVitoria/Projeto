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

            // Associar os eventos corretamente
            pictureBox3.MouseEnter += PictureBox1_MouseEnter;
            pictureBox3.MouseLeave += PictureBox1_MouseLeave;
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

        // Quando o mouse entra na área do PictureBox
        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Simular o efeito de destaque aumentando o PictureBox
            pictureBox3.Size = new Size(pictureBox3.Width + 10, pictureBox3.Height + 10);
            //pictureBox1.BorderStyle = BorderStyle.FixedSingle; // Adiciona uma borda
        }

        // Quando o mouse sai da área do PictureBox
        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar o tamanho original
            pictureBox3.Size = new Size(pictureBox3.Width - 10, pictureBox3.Height - 10);
            //pictureBox1.BorderStyle = BorderStyle.None; // Remove a borda
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
