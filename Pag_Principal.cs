using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2
{
    public partial class Pag_Principal : Form
    {
        private Boolean mostrepanelMenu1 = false;
        private Boolean mostrepanelMenu2 = false;
        public Pag_Principal()
        {
            InitializeComponent();
            tooglePanels();

            /*PictureBox[] pictureBoxes = { pictureBox1, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };

            // Associando eventos MouseEnter e MouseLeave para todos os PictureBox
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.MouseEnter += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
            }
            */


        }

        /*
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


        */

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

        /*
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
        */

        // Abre o quiz
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bloco4 bloco_4 = new Bloco4();
            bloco_4.ShowDialog();
            this.Show();
        }


        // Abre os créditos
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creditos creditos = new Creditos();
            creditos.ShowDialog();
            this.Show();
        }

        // Abre o bloco 5 (hidrometro)
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bloco5 bloco_5 = new Bloco5();
            bloco_5.ShowDialog();
            this.Show();
        }

        // Abre o bloco 1
        private void button1_Click_1(object sender, EventArgs e)
        {            
            this.Hide();
            Bloco01 bloco_1 = new Bloco01();
            bloco_1.ShowDialog();
            this.Show();
        }

        // Abre o bloco 2
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bloco2 bloco_2 = new Bloco2();
            bloco_2.ShowDialog();
            this.Show();
        }
        // Abre o bloco 3
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bloco3 bloco_3 = new Bloco3();
            bloco_3.ShowDialog();
            this.Show();
        }

        // Abre o menu 1
        private void iconButton1_Click(object sender, EventArgs e)
        {
            mostrepanelMenu1 = !mostrepanelMenu1;
            tooglePanels();

            
            if (mostrepanelMenu1)
            {
                iconButton1.BackgroundImage = Resources.B3conscientizaçãoBaixo; 
                iconButton1.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                iconButton1.BackgroundImage = Resources.B3_conscientização2; 
                iconButton1.BackgroundImageLayout = ImageLayout.Zoom;
            }

        }
        private void tooglePanels()
        {
            if(mostrepanelMenu1)
            {
                panelMenu1.Height = 90;
            }
            else
            {
                panelMenu1.Height = 0;
            }
            
            if (mostrepanelMenu2)
            {
                panelMenu2.Height = 90;
            }
            else
            {
                panelMenu2.Height = 0;
            }
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            mostrepanelMenu1 = !mostrepanelMenu1;
            tooglePanels();
        }

        // Abre o menu 2
        private void iconButton2_Click(object sender, EventArgs e)
        {
            mostrepanelMenu2 = !mostrepanelMenu2;
            tooglePanels();

            if (mostrepanelMenu2)
            {
                iconButton2.BackgroundImage = Resources.B4aprendizadoBaixo; 
                iconButton2.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                iconButton2.BackgroundImage = Resources.B4_aprendizado1; 
                iconButton2.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }        
        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Resize(object sender, EventArgs e)
        {
            
        }

        

    }
}
