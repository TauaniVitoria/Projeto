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
    public partial class Pagina_Inicial : Form
    {
        public Pagina_Inicial()
        {
            InitializeComponent();

            // Associar os eventos corretamente
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pag_Principal pag_Principal = new Pag_Principal();
            this.Hide();
            pag_Principal.Show();            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Pag_Principal pag_Principal = new Pag_Principal();
            this.Hide();
            pag_Principal.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
