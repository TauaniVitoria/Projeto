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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bloco2 bloco_2 = new Bloco2();
            bloco_2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bloco1 bloco_1 = new Bloco1();
            bloco_1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bloco3 bloco_3 = new Bloco3();
            bloco_3.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Bloco4 bloco_4 = new Bloco4();
            bloco_4.Show();
            this.Hide();
        }
        private void Pag_Principal_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) // Botão de voltar
        {
            // Fecha o Form2, automaticamente voltando ao Form1
            this.Close();

            // Opcional: Se o Form1 estiver oculto, reexibe-o
            Application.OpenForms["Pagina_Inicial"].Show();
        }
    }
}
