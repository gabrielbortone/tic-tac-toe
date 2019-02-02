using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha.GameConfig {
    class Player {
        public string Peca { get; set; }
        public int Wins { get; set; }

        public Player(string peca) {
            this.Peca = peca;
            this.Wins = 0;
        }

        public string Gaming(string btnText) {
                return Peca;
        }
    }
}
