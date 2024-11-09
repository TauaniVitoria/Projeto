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
           

             // Associa o evento Shown para garantir que a rolagem comece no topo
            this.Shown += new EventHandler(Bloco4_Shown);
        }

        private void Bloco4_Shown(object sender, EventArgs e)
        {
            // Define a posição da rolagem para o topo
            this.AutoScrollPosition = new Point(0, 0);
            this.groupBox1.Focus(); // Foca no primeiro botão para garantir a rolagem no topo
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bloco4_Load(object sender, EventArgs e)
        {
            groupBox1.Focus();
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

        int acertos = 0;
        // Alternativas da 1 pergunta
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                resultado1.Text = "Incorreto! A resposta correta é opção b";
                DesativarRadioButtons();
                radioButton1.Paint += radioButton1_Paint;
                radioButton1.Invalidate();
                this.AutoScrollPosition = new Point(0, 0);
                this.groupBox1.Focus();
            }
            else 
            {
                radioButton1.Paint -= radioButton1_Paint;
                radioButton1.Invalidate();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                resultado1.Text = "Correto!";
                // Método que bloqueia todos os RadioButtons após a resposta correta
                DesativarRadioButtons();
                acertos++;
                // Método que pinta a borda de verde
                radioButton2.Paint += radioButton2_Paint;
                radioButton2.Invalidate();
                this.AutoScrollPosition = new Point(0, 0);
                this.groupBox1.Focus();
            }
            else
            {
                radioButton2.Paint -= radioButton2_Paint;
                radioButton2.Invalidate();
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                resultado1.Text = "Incorreto! A resposta correta é opção b";
                DesativarRadioButtons();
                radioButton3.Paint += radioButton3_Paint;
                radioButton3.Invalidate();
                this.AutoScrollPosition = new Point(0, 0);
                this.groupBox1.Focus();
            }
            else
            {
                radioButton3.Paint -= radioButton3_Paint;
                radioButton3.Invalidate();
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                resultado1.Text = "Incorreto! A resposta correta é opção b";
                DesativarRadioButtons();
                radioButton4.Paint += radioButton4_Paint;
                radioButton4.Invalidate();
                this.AutoScrollPosition = new Point(0, 0);
                this.groupBox1.Focus();
            }
            else
            {
                radioButton4.Paint -= radioButton4_Paint;
                radioButton4.Invalidate();
            }
        }

        // Alternativas do pergunta 2
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                resposta2.Text = "Incorreto! A resposta correta é opção c";                
                DesativarAlt_Pergunta2();
                groupBox2.Focus();
                radioButton5.Paint += radioButton5_Paint;
                radioButton5.Invalidate();
            }
            else
            {
                radioButton5.Paint -= radioButton5_Paint;
                radioButton5.Invalidate();
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                resposta2.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta2();
                groupBox2.Focus();
                radioButton6.Paint += radioButton6_Paint;
                radioButton6.Invalidate();
            }
            else
            {
                radioButton6.Paint -= radioButton6_Paint;
                radioButton6.Invalidate();
            }
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                resposta2.Text = "Correto";
                // Método que bloqueia todos os RadioButtons após a resposta correta
                DesativarAlt_Pergunta2();
                acertos++;
                groupBox2.Focus();
                radioButton7.Paint += radioButton7_Paint;
                radioButton7.Invalidate();
            }
            else
            {
                radioButton7.Paint -= radioButton7_Paint;
                radioButton7.Invalidate();
            }
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                resposta2.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta2();
                groupBox2.Focus();
                radioButton8.Paint += radioButton8_Paint;
                radioButton8.Invalidate();
            }
            else
            {
                radioButton8.Paint -= radioButton8_Paint;
                radioButton8.Invalidate();
            }
        }

        // Alternativas da pergunta 3
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                resposta3.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta3();
                groupBox3.Focus();
                radioButton9.Paint += radioButton9_Paint;
                radioButton9.Invalidate();
            }
            else
            {
                radioButton9.Paint -= radioButton9_Paint;
                radioButton9.Invalidate();
            }
        }
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                resposta3.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta3();
                groupBox3.Focus();
                radioButton10.Paint += radioButton10_Paint;
                radioButton10.Invalidate();
            }
            else
            {
                radioButton10.Paint -= radioButton10_Paint;
                radioButton10.Invalidate();
            }
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                resposta3.Text = "Correto!";
                DesativarAlt_Pergunta3();
                acertos++;
                groupBox3.Focus();
                radioButton11.Paint += radioButton11_Paint;
                radioButton11.Invalidate();
            }
            else
            {
                radioButton11.Paint -= radioButton11_Paint;
                radioButton11.Invalidate();
            }
        }
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                resposta3.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta3();
                groupBox3.Focus();
                radioButton12.Paint += radioButton12_Paint;
                radioButton12.Invalidate();
            }
            else
            {
                radioButton12.Paint -= radioButton12_Paint;
                radioButton12.Invalidate();
            }
        }

        // Alternativas da pergunta 4
        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                resposta4.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta4();
                groupBox4.Focus();
                radioButton13.Paint += radioButton13_Paint;
                radioButton13.Invalidate();
            }
            else
            {
                radioButton13.Paint -= radioButton13_Paint;
                radioButton13.Invalidate();
            }
        }
        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                resposta4.Text = "Correto";
                DesativarAlt_Pergunta4();
                acertos++;
                groupBox4.Focus();
                radioButton14.Paint += radioButton14_Paint;
                radioButton14.Invalidate();
            }
            else
            {
                radioButton14.Paint -= radioButton14_Paint;
                radioButton14.Invalidate();
            }
        }
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked)
            {
                resposta4.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta4();
                groupBox4.Focus();
                radioButton15.Paint += radioButton15_Paint;
                radioButton15.Invalidate();
            }
            else
            {
                radioButton15.Paint -= radioButton15_Paint;
                radioButton15.Invalidate();
            }
        }
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked)
            {
                resposta4.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta4();
                groupBox4.Focus();
                radioButton16.Paint += radioButton16_Paint;
                radioButton16.Invalidate();
            }
            else
            {
                radioButton16.Paint -= radioButton16_Paint;
                radioButton16.Invalidate();
            }
        }

        // Alternativas da pergunta 5
        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked)
            {
                resposta5.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta5();
                groupBox5.Focus();
                radioButton17.Paint += radioButton17_Paint;
                radioButton17.Invalidate();
            }
            else
            {
                radioButton17.Paint -= radioButton17_Paint;
                radioButton17.Invalidate();
            }
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked)
            {
                resposta5.Text = "Correto";
                DesativarAlt_Pergunta5();
                acertos++;
                groupBox5.Focus();
                radioButton18.Paint += radioButton18_Paint;
                radioButton18.Invalidate();
            }
            else
            {
                radioButton18.Paint -= radioButton18_Paint;
                radioButton18.Invalidate();
            }
        }
        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked)
            {
                resposta5.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta5();
                groupBox5.Focus();
                radioButton19.Paint += radioButton19_Paint;
                radioButton19.Invalidate();
            }
            else
            {
                radioButton19.Paint -= radioButton19_Paint;
                radioButton19.Invalidate();
            }
        }
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton20.Checked)
            {
                resposta5.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta5();
                groupBox5.Focus();
                radioButton20.Paint += radioButton20_Paint;
                radioButton20.Invalidate();
            }
            else
            {
                radioButton20.Paint -= radioButton20_Paint;
                radioButton20.Invalidate();
            }
        }

        // Alternativas da pergunta 6
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked)
            {
                resposta6.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta6();
                groupBox6.Focus();
                radioButton21.Paint += radioButton21_Paint;
                radioButton21.Invalidate();
            }
            else
            {
                radioButton21.Paint -= radioButton21_Paint;
                radioButton21.Invalidate();
            }
        }
        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton22.Checked)
            {
                resposta6.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta6();
                groupBox6.Focus();
                radioButton22.Paint += radioButton21_Paint;
                radioButton22.Invalidate();
            }
            else
            {
                radioButton22.Paint -= radioButton22_Paint;
                radioButton22.Invalidate();
            }
        }
        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton23.Checked)
            {
                resposta6.Text = "Correto!";
                DesativarAlt_Pergunta6();
                acertos++;
                groupBox6.Focus();
                radioButton23.Paint += radioButton23_Paint;
                radioButton23.Invalidate();
            }
            else
            {
                radioButton23.Paint -= radioButton23_Paint;
                radioButton23.Invalidate();
            }
        }
        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton24.Checked)
            {
                resposta6.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta6();
                groupBox6.Focus();
                radioButton24.Paint += radioButton24_Paint;
                radioButton24.Invalidate();
            }
            else
            {
                radioButton24.Paint -= radioButton24_Paint;
                radioButton24.Invalidate();
            }
        }

        // Alternativas pergunta 7
        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton28.Checked)
            {
                resposta7.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta7();
                groupBox7.Focus();
                radioButton28.Paint += radioButton28_Paint;
                radioButton28.Invalidate();
            }
            else
            {
                radioButton28.Paint -= radioButton28_Paint;
                radioButton28.Invalidate();
            }
        }
        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton27.Checked)
            {
                resposta7.Text = "Correto";
                DesativarAlt_Pergunta7();
                acertos++;
                groupBox7.Focus();
                radioButton27.Paint += radioButton27_Paint;
                radioButton27.Invalidate();
            }
            else
            {
                radioButton27.Paint -= radioButton27_Paint;
                radioButton27.Invalidate();
            }
        }
        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton26.Checked)
            {
                resposta7.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta7();
                groupBox7.Focus();
                radioButton26.Paint += radioButton26_Paint;
                radioButton26.Invalidate();
            }
            else
            {
                radioButton26.Paint -= radioButton26_Paint;
                radioButton26.Invalidate();
            }
        }
        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton25.Checked)
            {
                resposta7.Text = "Incorreto! A resposta correta é opção b";
                DesativarAlt_Pergunta7();
                groupBox7.Focus();
                radioButton25.Paint += radioButton25_Paint;
                radioButton25.Invalidate();
            }
            else
            {
                radioButton25.Paint -= radioButton25_Paint;
                radioButton25.Invalidate();
            }
        }

        // Alternativa 8
        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked)
            {
                resposta8.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta8();
                groupBox8.Focus();
                radioButton32.Paint += radioButton32_Paint;
                radioButton32.Invalidate();
            }
            else
            {
                radioButton32.Paint -= radioButton32_Paint;
                radioButton32.Invalidate();
            }
        }
        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton31.Checked)
            {
                resposta8.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta8();
                groupBox8.Focus();
                radioButton31.Paint += radioButton31_Paint;
                radioButton31.Invalidate();
            }
            else
            {
                radioButton31.Paint -= radioButton31_Paint;
                radioButton31.Invalidate();
            }
        }
        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton30.Checked)
            {
                resposta8.Text = "Correto";
                DesativarAlt_Pergunta8();
                acertos++;
                groupBox8.Focus();
                radioButton30.Paint += radioButton30_Paint;
                radioButton30.Invalidate();      
            }  
            else
            {
                radioButton30.Paint -= radioButton30_Paint;
                radioButton30.Invalidate();
            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton29.Checked)
            {
                resposta8.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta8();
                groupBox8.Focus();
                radioButton29.Paint += radioButton29_Paint;
                radioButton29.Invalidate();
            }
            else
            {
                radioButton29.Paint -= radioButton29_Paint;
                radioButton29.Invalidate();
            }
        }

        // Alternativas pergunta 9
        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton36.Checked)
            {
                resposta9.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta9();
                groupBox9.Focus();
                radioButton36.Paint += radioButton36_Paint;
                radioButton36.Invalidate();
            }
            else
            {
                radioButton36.Paint -= radioButton36_Paint;
                radioButton36.Invalidate();
            }
        }
        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton35.Checked)
            {
                resposta9.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta9();
                groupBox9.Focus();
                radioButton35.Paint += radioButton35_Paint;
                radioButton35.Invalidate();
            }
            else
            {
                radioButton35.Paint -= radioButton35_Paint;
                radioButton35.Invalidate();
            }
        }
        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton34.Checked)
            {
                resposta9.Text = "Correto";
                DesativarAlt_Pergunta9();
                acertos++;
                groupBox9.Focus();
                radioButton34.Paint += radioButton34_Paint;
                radioButton34.Invalidate();
            }
            else
            {
                radioButton34.Paint -= radioButton34_Paint;
                radioButton34.Invalidate();
            }

        }
        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton33.Checked)
            {
                resposta9.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta9();
                groupBox9.Focus();
                radioButton33.Paint += radioButton33_Paint;
                radioButton33.Invalidate();
            }
            else
            {
                radioButton33.Paint -= radioButton33_Paint;
                radioButton33.Invalidate();
            }
        }

        // alternativas da pergunta 10
        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton40.Checked)
            {
                resposta10.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta10();
                this.groupBox11_Enter();
                radioButton40.Paint += radioButton40_Paint;
                radioButton40.Invalidate();
            }
            else
            {
                radioButton40.Paint -= radioButton40_Paint;
                radioButton40.Invalidate();
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton39.Checked)
            {
                resposta10.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta10();
                this.groupBox11_Enter();
                radioButton39.Paint += radioButton39_Paint;
                radioButton39.Invalidate();
            }
            else
            {
                radioButton39.Paint -= radioButton39_Paint;
                radioButton39.Invalidate();
            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton38.Checked)
            {
                resposta10.Text = "Correto!";
                DesativarAlt_Pergunta10();
                this.groupBox11_Enter();
                radioButton38.Paint += radioButton38_Paint;
                radioButton38.Invalidate();
            }
            else
            {
                radioButton38.Paint -= radioButton38_Paint;
                radioButton38.Invalidate();
            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton37.Checked)
            {
                resposta10.Text = "Incorreto! A resposta correta é opção c";
                DesativarAlt_Pergunta10();
                this.groupBox11_Enter();
                radioButton37.Paint += radioButton37_Paint;
                radioButton37.Invalidate();
            }
            else
            {
                radioButton37.Paint -= radioButton37_Paint;
                radioButton37.Invalidate();
            }
        }

        // Método para desenhar a borda vermelha (alternativas erradas)
        private void radioButton1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton1.Width - 1, radioButton1.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
        private void radioButton3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton3.Width - 1, radioButton3.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton4_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton4.Width - 1, radioButton4.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
        private void radioButton5_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton5.Width - 1, radioButton5.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton6_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton6.Width - 1, radioButton6.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton8_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton8.Width - 1, radioButton8.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton9_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton9.Width - 1, radioButton9.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton10_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton10.Width - 1, radioButton10.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton12_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton12.Width - 1, radioButton12.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton13_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton13.Width - 1, radioButton13.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton15_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton15.Width - 1, radioButton15.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
        private void radioButton16_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton16.Width - 1, radioButton16.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
        private void radioButton17_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton17.Width - 1, radioButton17.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
        private void radioButton19_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton19.Width - 1, radioButton19.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton20_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton20.Width - 1, radioButton20.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton21_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton21.Width - 1, radioButton21.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton22_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton22.Width - 1, radioButton22.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton24_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton24.Width - 1, radioButton24.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton25_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton25.Width - 1, radioButton25.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton26_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton26.Width - 1, radioButton26.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton28_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton28.Width - 1, radioButton28.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton29_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton29.Width - 1, radioButton29.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton31_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton31.Width - 1, radioButton31.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton32_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton32.Width - 1, radioButton32.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton33_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton33.Width - 1, radioButton33.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton35_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton35.Width - 1, radioButton35.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton36_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton36.Width - 1, radioButton36.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton37_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton37.Width - 1, radioButton37.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton39_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton39.Width - 1, radioButton39.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton40_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton40.Width - 1, radioButton40.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        // Método para desenhar a borda verde
        private void radioButton2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton2.Width - 1, radioButton2.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }
        private void radioButton7_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton7.Width - 1, radioButton7.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton11_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton11.Width - 1, radioButton11.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton14_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton14.Width - 1, radioButton14.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton18_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton18.Width - 1, radioButton18.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton23_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton23.Width - 1, radioButton23.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton27_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton27.Width - 1, radioButton27.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton30_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton30.Width - 1, radioButton30.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton34_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton34.Width - 1, radioButton34.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
        }

        private void radioButton38_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Green, 2);
            Rectangle rect = new Rectangle(0, 0, radioButton38.Width - 1, radioButton38.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            pen.Dispose();
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

        private void groupBox11_Enter()
        {
            string ac = acertos.ToString();
            resultado.Text = $"{ac}";
        }




        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }

        private void numb1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void resposta5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }
    }
}

