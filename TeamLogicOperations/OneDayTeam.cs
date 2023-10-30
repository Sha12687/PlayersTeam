using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLogicOperations
{
    internal class OneDayTeam : ITeam

    {
        public static List<Player> oneDayTeam;
        public OneDayTeam(int teamSize) {
        oneDayTeam = new List<Player>(teamSize);
        }
        public void Add(Player player)
        {
            Console.Write("Enter Player ID: ");
            int playerId = int.Parse(Console.ReadLine());
            Console.Write("Enter Player Name: ");
            string playerName = Console.ReadLine();
            Console.Write("Enter Player Age: ");
            int playerAge = int.Parse(Console.ReadLine());
            oneDayTeam.Add(new Player { PlayerId = playerId, Name = playerName, Age = playerAge });
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

        public Player GetPlayerById(int playerId)
        {
            Console.Write("Enter Player ID: ");
            int getById = int.Parse(Console.ReadLine());
           Player playerById= oneDayTeam.FirstOrDefault(p => p.PlayerId == playerId);
            return playerById;
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.FirstOrDefault(p => p.Name == playerName);
        }

        public void Remove(int playerId)
        {
            Console.Write("Enter Player ID to remove: ");
            int removeId = int.Parse(Console.ReadLine());
            Player playerToRemove = oneDayTeam.FirstOrDefault(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Name} removed from the team.");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
    }
}
