using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersTeam
{
    internal class Teams
    {
        private List<Player> players = new List<Player>();
        public void AddPlayer(Player player)
        {
            if (players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player is added successfully.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players.");
            }   
        }
        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public Player GetPlayersByName(string playerName)
        {
            return players.FirstOrDefault(p=> p.Name == playerName);
                
                }

        public List<Player> GetAllPlayers()
        {
            return players;
        }
    }
    }
