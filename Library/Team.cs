using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Team
    {
        string name;

        /// <summary>
        /// List of players of the Team
        /// </summary>
        List<Player> players;

        /// <summary>
        /// Team captain
        /// </summary>
        Player? captain;
        
        /// <summary>
        /// Maximum number of players for each role
        /// </summary>
        const int MAX_RISERVA_PLAYERS = 3;
        const int MAX_ROSA_PLAYERS = 11;
        int nGiocatoriRosa, nGiocatoriRiserva;  //numero di giocatori rosa e riserva attualmente nella lista

        public Team(string name)
        {
            this.name = name;
            players = new List<Player>();
            nGiocatoriRiserva= 0;
            nGiocatoriRosa = 0;
        }

        /// <summary>
        /// Adding player to a Team
        /// 
        /// We can have a maximum of MAX_ROSA_PLAYERS rosa's players and MAX_RISERVA_PLAYERS riserva's player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>True if player has been inserted</returns>
        public bool AddPlayer(Player player)
        {
            if (player.Role == Player.ERole.Rosa)
            {
                if (nGiocatoriRosa <= MAX_ROSA_PLAYERS)
                {
                    players.Add(player);
                    nGiocatoriRosa++;
                    return true;
                }
                else return false;
            }
            else if (player.Role == Player.ERole.Riserva)
            {
                if (nGiocatoriRiserva <= MAX_RISERVA_PLAYERS)
                {
                    players.Add(player);
                    nGiocatoriRiserva++;
                    return true;
                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// Setting captain of the Team
        /// 
        /// Captain must be in the Rosa role
        /// </summary>
        /// <param name="captain"></param>
        /// <returns>True if captain has been setted</returns>
        public bool AddCaptain(Player captain)
        {
            if (captain.Role == Player.ERole.Rosa)
            {
                this.captain = captain;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Get a list of players of the team
        /// </summary>
        /// <returns></returns>
        public string GetPlayers()
        {
            string description = "";
            for(int c = 0; c < players.Count; c++)
            {
                description = description + players[c].Description() + ", \n";
            }
            return description;
        }

        public string Name { get { return name; } }

        public Player? Captain { get { return captain; } }
    }
}
