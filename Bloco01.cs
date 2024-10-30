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
    public partial class Bloco01 : Form
    {
        public Bloco01()
        {
            InitializeComponent();
        }

        // Fecha o form, voltando para form1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
