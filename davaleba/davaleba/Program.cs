using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace davaleba
{
    internal class Program
    {
    




    }

    class Player
    {

        public string PlayerName { get; set; }
        public int health { get; set; }

        public int ShootingDamage { get; set; }


        public Player(string name, int health, int damage)
        {
            PlayerName = name;
            this.health = health; 
            ShootingDamage = damage;
        }


    }



    public class Program1
    {
        private static List<Player> nextround;

        static void Main()
        {


            var Players = new List<Player>
             {
    new Player("Saba", 200, 50),
    new Player("Dato", 200, 50),
    new Player("Giorgi", 200, 50)
             };


            while (Players.Count > 1) {
            
             nextround = new List<Player>(); 
                for (int i = 0; i < Players.Count; i++)
                {
                    var player = Players[i];    
                    var player1 = Players[i + 1];

                    if (player.ShootingDamage > player1.ShootingDamage)
                    {
                        nextround.Add(player);  
                    }

                    else { 
                    nextround.Add(player1);  }
                }    
            }

            Players = nextround;

            var winner = Players[0];
            Console.WriteLine($"winner is {winner.PlayerName}");
        }
       
      
       



        }
}
