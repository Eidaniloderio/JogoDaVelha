using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class PlayerVsPlayer : Form
    {
        public PlayerVsPlayer()
        {
            InitializeComponent();
        }

        string caminhoFotoX = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/simbolo-x.png";
        string caminhoFotoBolinha = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/anel-circular.png";
        string caminhoFotoBranco = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/fundo_transparente.png";

        string[] jogada = new string[9];
        int vitoriasO;
        int vitoriasX;
        int empates;


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    pictureBox1.Image = Image.FromFile(caminhoFotoX); 
                    break;
                case MouseButtons.Right:
                    pictureBox1.Image = Image.FromFile(caminhoFotoBolinha);
                    break;
            }

            jogadas();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (pictureBox2.Image == null || pictureBox2.Image == Image.FromFile(caminhoFotoBolinha))
                {
                    jogada[1] = "x";
                    pictureBox2.Image = Image.FromFile(caminhoFotoX);
                }
                else if (pictureBox2.Image != null)
                {
                    pictureBox2.Image = null;
                }

            }

            if (e.Button == MouseButtons.Right)
            {
                if (pictureBox2.Image == null || pictureBox2.Image == Image.FromFile(caminhoFotoX))
                {
                    jogada[1] = "o";
                    pictureBox2.Image = Image.FromFile(caminhoFotoBolinha);
                }
                else if (pictureBox2.Image != null)
                {
                    pictureBox2.Image = null;
                }
            }

            jogadas();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (pictureBox3.Image == null || pictureBox3.Image == Image.FromFile(caminhoFotoBolinha))
                {
                    jogada[2] = "x";
                    pictureBox3.Image = Image.FromFile(caminhoFotoX);
                }
                else if (pictureBox3.Image != null)
                {
                    pictureBox3.Image = null;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (pictureBox3.Image == null || pictureBox3.Image == Image.FromFile(caminhoFotoX))
                {
                    jogada[2] = "o";
                    pictureBox3.Image = Image.FromFile(caminhoFotoBolinha);
                }
                else if ( pictureBox3.Image != null)
                {
                    pictureBox3.Image = null;
                }
            }

            jogadas();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (pictureBox4.Image == null || pictureBox4.Image == Image.FromFile(caminhoFotoBolinha))
                {
                    jogada[3] = "x";
                    pictureBox4.Image = Image.FromFile(caminhoFotoX);
                }
                else if (pictureBox4.Image != null)
                {
                    pictureBox4.Image = null;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (pictureBox5.Image == null || pictureBox5.Image == Image.FromFile(caminhoFotoX))
                {
                    jogada[3] = "o";
                    pictureBox4.Image = Image.FromFile(caminhoFotoBolinha);
                }
                else if (pictureBox5.Image != null)
                {
                    pictureBox4.Image = null;
                }
            }

            jogadas();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (pictureBox5.Image == null || pictureBox5.Image == Image.FromFile(caminhoFotoBolinha))
                {
                    jogada[4] = "x";
                    pictureBox5.Image = Image.FromFile(caminhoFotoX);
                }
                else if (pictureBox5.Image != null)
                {
                    pictureBox5.Image = null;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (pictureBox5.Image == null || pictureBox5.Image == Image.FromFile(caminhoFotoX))
                {
                    jogada[4] = "o";
                    pictureBox5.Image = Image.FromFile(caminhoFotoBolinha);
                }
                else if (pictureBox5.Image != null)
                {

                }
            }

            jogadas();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                jogada[5] = "x";
                pictureBox6.Image = Image.FromFile(caminhoFotoX);
            }

            if (e.Button == MouseButtons.Right)
            {
                jogada[5] = "o";
                pictureBox6.Image = Image.FromFile(caminhoFotoBolinha);
            }

            jogadas();
        }
        private void pictureBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile(caminhoFotoBranco);
            jogada[5] = "";
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                jogada[6] = "x";
                pictureBox7.Image = Image.FromFile(caminhoFotoX);
            }

            if (e.Button == MouseButtons.Right)
            {
                jogada[6] = "o";
                pictureBox7.Image = Image.FromFile(caminhoFotoBolinha);
            }

            jogadas();
        }
        private void pictureBox7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Image.FromFile(caminhoFotoBranco);
            jogada[6] = "";
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                jogada[7] = "x";
                pictureBox8.Image = Image.FromFile(caminhoFotoX);
            }

            if (e.Button == MouseButtons.Right)
            {
                jogada[7] = "o";
                pictureBox8.Image = Image.FromFile(caminhoFotoBolinha);
            }

            jogadas();
        }

        private void pictureBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Image = Image.FromFile(caminhoFotoBranco);
            jogada[7] = "";
        }


        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                jogada[8] = "x";
                pictureBox9.Image = Image.FromFile(caminhoFotoX);
            }

            if (e.Button == MouseButtons.Right)
            {
                jogada[8] = "o";
                pictureBox9.Image = Image.FromFile(caminhoFotoBolinha);
            }

            jogadas();

        }

        private void pictureBox9_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox9.Image = Image.FromFile(caminhoFotoBranco);
            jogada[8] = "";
        }

        private void jogadas()
        {

            // Vitorias do X
            if (jogada[0] == "x" && jogada[1] == "x" && jogada[2] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();

                return;
            }

            if (jogada[0] == "x" && jogada[3] == "x" && jogada[6] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();


                return;
            }

            if (jogada[0] == "x" && jogada[4] == "x" && jogada[8] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();


                return;
            }

            if (jogada[1] == "x" && jogada[4] == "x" && jogada[7] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();


                return;
            }

            if (jogada[2] == "x" && jogada[5] == "x" && jogada[8] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();

                return;
            }

            if (jogada[2] == "x" && jogada[4] == "x" && jogada[6] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();

                return;
            }

            if (jogada[3] == "x" && jogada[4] == "x" && jogada[5] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();

                return;
            }

            if (jogada[6] == "x" && jogada[7] == "x" && jogada[8] == "x")
            {
                MessageBox.Show("O 'X' Venceu");
                limpaQuadrados();

                vitoriasX += 1;

                txtVitoriasX.Text = vitoriasX.ToString();

                return;
            }


            // Vitorias da O

            if (jogada[0] == "o" && jogada[1] == "o" && jogada[2] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            if (jogada[0] == "o" && jogada[3] == "o" && jogada[6] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            if (jogada[0] == "o" && jogada[4] == "o" && jogada[8] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();


                return;
            }

            if (jogada[1] == "o" && jogada[4] == "o" && jogada[7] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            if (jogada[2] == "o" && jogada[5] == "o" && jogada[8] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            if (jogada[2] == "o" && jogada[4] == "o" && jogada[6] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            if (jogada[3] == "o" && jogada[4] == "o" && jogada[5] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            if (jogada[6] == "o" && jogada[7] == "o" && jogada[8] == "o")
            {
                MessageBox.Show("A bolinha Venceu!");
                limpaQuadrados();

                vitoriasO += 1;

                txtVitoriasO.Text = vitoriasO.ToString();

                return;
            }

            // Vefiricando Empates 

            bool empate = true;
            foreach (string jogadaAtual in jogada)
            {
                if (string.IsNullOrEmpty(jogadaAtual))
                {
                    empate = false;
                    break;
                }
            }

            if (empate)
            {
                MessageBox.Show("Deu Velha. O jogo EMPATOU!");
                limpaQuadrados();

                empates += 1;

                txtEmpates.Text = empates.ToString();

                return;
            }

        }

        private void limpaQuadrados()
        {
            pictureBox1.Image = null;
            jogada[0] = "";
            pictureBox2.Image = null;
            jogada[1] = "";
            pictureBox3.Image = null;
            jogada[2] = "";
            pictureBox4.Image = null;
            jogada[3] = "";
            pictureBox5.Image = null;
            jogada[4] = "";
            pictureBox6.Image = null;
            jogada[5] = "";
            pictureBox7.Image = null;
            jogada[6] = "";
            pictureBox8.Image = null;
            jogada[7] = "";
            pictureBox9.Image = null;
            jogada[8] = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtVitoriasX.Text = "0";
            txtVitoriasO.Text = "0";
            txtEmpates.Text = "0";
        }
    }
}

