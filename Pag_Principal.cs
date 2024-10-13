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
    public partial class Pag_Principal : Form
    {
        public Pag_Principal()
        {
            InitializeComponent();

            PictureBox[] pictureBoxes = { pictureBox1, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };

            // Associando eventos MouseEnter e MouseLeave para todos os PictureBox
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.MouseEnter += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco2 bloco_2 = new Bloco2();
            bloco_2.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco1 bloco_1 = new Bloco1();
            bloco_1.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco3 bloco_3 = new Bloco3();
            bloco_3.ShowDialog();
            this.Show();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco4 bloco_4 = new Bloco4();
            bloco_4.ShowDialog();
            this.Show();

        }
        private void Pag_Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Fecha o Form2, automaticamente voltando ao Form1
            this.Close();

            // Opcional: Se o Form1 estiver oculto, reexibe-o
            Application.OpenForms["Pagina_Inicial"].Show();
        }

        // Quando o mouse entra na área do PictureBox
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.Size = new Size(pictureBox.Width + 10, pictureBox.Height + 10);
                // Você pode adicionar mais efeitos visuais aqui, como bordas
            }
        }

        // Evento para quando o mouse sai da área de qualquer PictureBox
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.Size = new Size(pictureBox.Width - 10, pictureBox.Height - 10);
                // Remova o efeito visual aqui, se necessário
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pag_Principal_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //bloco 1
            this.Hide();
            Bloco1 bloco_1 = new Bloco1();
            bloco_1.ShowDialog();
            this.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco2 bloco_2 = new Bloco2();
            bloco_2.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco3 bloco_3 = new Bloco3();
            bloco_3.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco4 bloco_4 = new Bloco4();
            bloco_4.ShowDialog();
            this.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creditos creditos = new Creditos();
            creditos.ShowDialog();
            this.Show();
        }
    }
}
