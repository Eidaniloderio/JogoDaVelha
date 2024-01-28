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
    public partial class PlayerVsComputador : Form
    {

        string marcacaoJogo;
        string marcacaoPC;
        public PlayerVsComputador()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (pictureBox1.Image == null)
            {
                MarcacaoJogada();
                pictureBox1.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MarcacaoJogada();
                pictureBox2.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox2.Image = null;
            }
        }
        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox3.Image == null)
            {
                MarcacaoJogada();
                pictureBox3.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox3.Image = null;
            }
        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox4.Image == null)
            {
                MarcacaoJogada();
                pictureBox4.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox4.Image = null;
            }
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox5.Image == null)
            {
                MarcacaoJogada();
                pictureBox5.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox5.Image = null;
            }
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox6.Image == null)
            {
                MarcacaoJogada();
                pictureBox6.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox6.Image = null;
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox7.Image == null)
            {
                MarcacaoJogada();
                pictureBox7.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox7.Image = null;
            }
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox8.Image == null)
            {
                MarcacaoJogada();
                pictureBox8.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox8.Image = null;
            }
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox9.Image == null)
            {
                MarcacaoJogada();
                pictureBox9.Image = Image.FromFile(marcacaoJogo);
            }
            else
            {
                pictureBox9.Image = null;
            }
        }

        private void MarcacaoJogada()
        {
            
            if (rbtnX.Checked)
            {
                marcacaoJogo = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/simbolo-x.png";
                marcacaoPC = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/anel-circular.png";
                return;
            }
            if (rbtnO.Checked)
            {
                marcacaoJogo = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/anel-circular.png";
                marcacaoPC = "C:/Users/Pichau/Documents/programação/pessoais/JogoDaVelha/midias/simbolo-x.png";
                return;
            }
           
        }

        private void JogadaPc()
        {
            
        }


    }
}
