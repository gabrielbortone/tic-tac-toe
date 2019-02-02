using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jogo_da_Velha.GameConfig;

namespace Jogo_da_Velha.GameConfig {
    public partial class FrmConfig : Form {
        public FrmConfig() {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e) {
            if(OptP1.Text == "X") {
                OptP1.Text = "O";
                OptP2.Text = "X";
            }
            else {
                OptP1.Text = "X";
                OptP2.Text = "O";
            }
        }

        private void btnInit_Click(object sender, EventArgs e) {
            Player play1, play2;
            play1 = new Player(OptP1.Text);
            play2 = new Player(OptP2.Text);

            Config.InitialGame(play1, play2);
            this.Close();
        }

        private void FrmConfig_Load(object sender, EventArgs e) {

        }
    }
}
