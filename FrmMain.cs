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

namespace Jogo_da_Velha {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }
        public bool IsWin { get; set; }

        void VerificaVitoria() {

            string Peca = Config.player_gaming.Peca;
            IsWin = false;

            //Linhas
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && Peca == btn3.Text)
                IsWin = true;
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && Peca == btn6.Text)
                IsWin = true;
            if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && Peca == btn9.Text)
                IsWin = true;
            //Colunas
            if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && Peca == btn7.Text)
                IsWin = true;
            if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && Peca == btn8.Text)
                IsWin = true;
            if (btn3.Text == btn6.Text && btn6.Text == btn9.Text && Peca == btn9.Text)
                IsWin = true;
            //Diagonais
            if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && Peca == btn9.Text)
                IsWin = true;
            if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && Peca == btn7.Text)
                IsWin = true;

            if (IsWin) {
                if(Config.player_gaming == Config.player1) {
                    Config.player1.Wins += 1;
                    P1Wins.Text = Convert.ToString(Config.player1.Wins);
                    Clear();
                }
                else {
                    Config.player2.Wins += 1;
                    P2Wins.Text = Convert.ToString(Config.player2.Wins);
                    Clear();
                }
            }
        }

        public void Clear() {
            btn1.Text = " ";
            btn2.Text = " ";
            btn3.Text = " ";
            btn4.Text = " ";
            btn5.Text = " ";
            btn6.Text = " ";
            btn7.Text = " ";
            btn8.Text = " ";
            btn9.Text = " ";
        }

        public bool IsDraw() {
            if (btn1.Text != " " && btn2.Text != " " && btn3.Text != " " && btn4.Text != " " && btn5.Text != " "
                && btn6.Text != " " && btn7.Text != " " && btn8.Text != " " && btn9.Text != " ") {
                return true;
            }
            return false;
        }

        public void btnGaming(Button btn) {
            if (btn.Text == " ") {
                btn.Text = Config.player_gaming.Gaming(btn.Text);
                VerificaVitoria();
                YourTurn.Text = Config.ChangePlayer();
            }
            if(IsDraw())
            {
                VerificaVitoria();
                if (!IsWin) {
                    int Ndraw = int.Parse(NDraws.Text) + 1;
                    NDraws.Text = Convert.ToString(Ndraw);
                    YourTurn.Text = Config.ChangePlayer();
                    Clear();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void FrmMain_Load(object sender, EventArgs e) {
            FrmConfig config_form = new FrmConfig();
            config_form.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            Clear();
        }

        private void btn1_Click(object sender, EventArgs e) {
            btnGaming(btn1);
        }

        private void btn2_Click(object sender, EventArgs e) {
            btnGaming(btn2);
        }

        private void btn3_Click(object sender, EventArgs e) {
            btnGaming(btn3);
        }

        private void btn4_Click(object sender, EventArgs e) {
            btnGaming(btn4);
        }

        private void btn5_Click(object sender, EventArgs e) {
            btnGaming(btn5);
        }

        private void btn6_Click(object sender, EventArgs e) {
            btnGaming(btn6);
        }

        private void btn7_Click(object sender, EventArgs e) {
            btnGaming(btn7);
        }

        private void btn8_Click(object sender, EventArgs e) {
            btnGaming(btn8);
        }

        private void btn9_Click(object sender, EventArgs e) {
            btnGaming(btn9);
        }
    }
}
