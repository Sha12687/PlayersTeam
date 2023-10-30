using PlayersTeam;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Teams cricketTeam = new Teams();
        bool flag = true;
        while (flag)
        {
            Console.Write("Enter 1: To Add Player ");
            Console.Write(" 2: To  Remove Player ");
            Console.Write(" 3: To  Get Player by ID ");
            Console.Write(" 4: To  Get Players by Name ");
            Console.Write(" 5: To  Get All Players");
            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Player ID: ");
                    int playerId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Player Name: ");
                    string playerName = Console.ReadLine();
                    Console.Write("Enter Player Age: ");
                    int playerAge = int.Parse(Console.ReadLine());

                    cricketTeam.AddPlayer(new Player { PlayerId = playerId, Name = playerName, Age = playerAge });
                    break;

                case 2:
                    Console.Write("Enter Player ID to remove: ");
                    int removeId = int.Parse(Console.ReadLine());
                    cricketTeam.RemovePlayer(removeId);
                    break;

                case 3:
                    Console.Write("Enter Player ID: ");
                    int getById = int.Parse(Console.ReadLine());
                    Player playerById = cricketTeam.GetPlayerById(getById);
                    if (playerById != null)
                    {
                        Console.WriteLine($"Player ID: {playerById.PlayerId}, Name: {playerById.Name}, Age: {playerById.Age}");
                    }
                    else
                    {
                        Console.WriteLine("Player not found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter Player Name: ");
                    string getByName = Console.ReadLine();
                    Player playersByName = cricketTeam.GetPlayersByName(getByName);
                    if(playersByName != null)
                    {
                        Console.WriteLine($"Player ID: {playersByName.PlayerId}, Name: {playersByName.Name}, Age: {playersByName.Age}");
                    }
                    else
                    {
                        Console.WriteLine("Player not found.");
                    }
                    break;

                case 5:
                    List<Player> allPlayers = cricketTeam.GetAllPlayers();
                    foreach (var player in allPlayers)
                    {
                        Console.WriteLine($"Player ID: {player.PlayerId}, Name: {player.Name}, Age: {player.Age}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.Write("\n Do you want to continue(yes/no)?:");
            string readCondition=Console.ReadLine();
            if (readCondition == "Yes" || readCondition == "yes")
            {
                flag = true;
            }
            else
            {
               flag= false;
            }
        }
    }
}
