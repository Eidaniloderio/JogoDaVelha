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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerVsPlayer frmPvp = new PlayerVsPlayer();
            frmPvp.ShowDialog();

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerVsComputador frmPvC = new PlayerVsComputador();
            frmPvC.ShowDialog();
            Close();
        }
    }
}
