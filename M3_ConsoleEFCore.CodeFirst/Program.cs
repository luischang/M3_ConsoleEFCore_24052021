using M3_ConsoleEFCore.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace M3_ConsoleEFCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new MundialDBContext();


            //var player1 = new Player()
            //{
            //    FullName = "Cristiano Ronaldo",
            //    Dorsal= 7
            //};

            ////Add Player
            //context.Player.Add(player1);
            //context.SaveChanges();

            //var player2 = new Player()
            //{
            //    FullName = "Lionel Messi",
            //    Dorsal = 10
            //};

            //var player3 = new Player()
            //{
            //    FullName = "Gianluigui Buffon",
            //    Dorsal = 1
            //};

            //var player4 = new Player()
            //{
            //    FullName = "Paolo Guerrero",
            //    Dorsal = 9
            //};


            //var playerList = new List<Player>();
            //playerList.Add(player2);
            //playerList.Add(player3);
            //playerList.Add(player4);

            ////Add Player
            //context.Player.AddRange(playerList);
            //context.SaveChanges();

            //Remove Player
            //-->Query by LINQ

            //var search = (from p in context.Player
            //              where p.Dorsal == 1
            //              select p).FirstOrDefault();

            //context.Player.Remove(search);
            //context.SaveChanges();


            //-->Query by Lambda expressions

            //var result = context.Player.Where(x => x.Dorsal == 10).FirstOrDefault();
            //context.Player.Remove(result);
            //context.SaveChanges();


            //Update player

            var result = context.Player.Where(x => x.Dorsal == 9).FirstOrDefault();
            result.FullName = "Francesco Totti";
            context.SaveChanges();


            Console.ReadKey();
        }
    }
}
