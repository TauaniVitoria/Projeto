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
    public partial class Bloco4 : Form
    {
        public Bloco4()
        {
            InitializeComponent();

            // Associar os eventos corretamente
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bloco4_Load(object sender, EventArgs e)
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



        // Métodos responsáveis por desabilitar as alternativas 
        private void DesativarRadioButtons()
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }
        private void DesativarAlt_Pergunta2()
        {
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
        }

        private void DesativarAlt_Pergunta3()
        {
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
        }

        private void DesativarAlt_Pergunta4()
        {
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
        }

        private void DesativarAlt_Pergunta5()
        {
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;
        }

        private void DesativarAlt_Pergunta6()
        {
            radioButton21.Enabled = false;
            radioButton22.Enabled = false;
            radioButton23.Enabled = false;
            radioButton24.Enabled = false;
        }

        private void DesativarAlt_Pergunta7()
        {
            radioButton25.Enabled = false;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
            radioButton28.Enabled = false;
        }

        private void DesativarAlt_Pergunta8()
        {
            radioButton29.Enabled = false;
            radioButton30.Enabled = false;
            radioButton31.Enabled = false;
            radioButton32.Enabled = false;
        }

        private void DesativarAlt_Pergunta9()
        {
            radioButton33.Enabled = false;
            radioButton34.Enabled = false;
            radioButton35.Enabled = false;
            radioButton36.Enabled = false;
        }

        private void DesativarAlt_Pergunta10()
        {
            radioButton37.Enabled = false;
            radioButton38.Enabled = false;
            radioButton39.Enabled = false;
            radioButton40.Enabled = false;
        }

        // Alternativas da 1 pergunta
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                resultado1.Text = "Correto! H₂O é a composição da água.";
                // Método que bloqueia todos os RadioButtons após a resposta correta
                DesativarRadioButtons(); 
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas do pergunta 2
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                resposta2.Text = "Correto! Realizar a fotossíntese é a função principal atividade realizada pela água durante os processos metabólicos";
                // Método que bloqueia todos os RadioButtons após a resposta correta
                DesativarAlt_Pergunta2();
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas da pergunta 3
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                resposta3.Text = "Correto!";
                DesativarAlt_Pergunta3();
            }
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas da pergunta 4
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                resposta4.Text = "Correto";
                DesativarAlt_Pergunta4();
            }
        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas da pergunta 5
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                resposta5.Text = "Correto";
                DesativarAlt_Pergunta5();
            }
        }
        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas da pergunta 6
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked)
            {
                resposta6.Text = "Correto!";
                DesativarAlt_Pergunta6();
            }
        }
        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas pergunta 7
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                resposta7.Text = "Correto";
                DesativarAlt_Pergunta7();
            }
        }
        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativa 8
        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            resposta8.Text = "Correto";
            DesativarAlt_Pergunta8();
        }
        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }

        // Alternativas pergunta 9
        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            resposta9.Text = "Correto";
            DesativarAlt_Pergunta9();
        }
        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                MessageBox.Show("Incorreto! Mas você pode tentar novamente");
            }
        }
        
        
        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void pergunta2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Resposta2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}

