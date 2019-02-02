using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Velha.GameConfig {
    class Config {
        public static Player player1 { get; set; }
        public static Player player2 { get; set; }
        public static Player player_gaming { get; set; }

        public static void InitialGame(Player play1, Player play2) {
            player1 = play1;
            player2 = play2;
            player_gaming = player1;
        }
         
        public static string ChangePlayer() {
            if(player_gaming == player1) {
                player_gaming = player2;
                return "Sua vez, Player 2";
            }
            else {
                player_gaming = player1;
                return "Sua vez, Player 1";
            }
        }
    }
}
