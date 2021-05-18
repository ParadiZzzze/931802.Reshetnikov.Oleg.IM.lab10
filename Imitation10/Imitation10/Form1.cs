using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imitation10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            int[] player1_res = game.common_roll();
            int[] player2_res = game.cheat_roll();
            label1.Text = Convert.ToString(player1_res[0]);
            label2.Text = Convert.ToString(player1_res[1]);
            label3.Text = Convert.ToString(player2_res[0]);
            label4.Text = Convert.ToString(player2_res[1]);
            label7.Text = Convert.ToString(player1_res.Sum());
            label8.Text = Convert.ToString(player2_res.Sum());
            string res = "player2 wins";
            if (player1_res.Sum()>= player2_res.Sum()) res = "player1 wins";
            label9.Text = res;
        }
    }
}
