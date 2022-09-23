using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodTest
{
    public class CoApp
    {
        public void Run()
        {
            var data = GetData();
            while (true)
            {
                Console.WriteLine("                                                         ");
                Console.WriteLine("Když zadáte číslo uživatele tak vám to vypíše jaké hry hrál.");
                Console.WriteLine("zadejte číslo uživatele.");
                var number = Console.ReadLine();
                var sum = 0;
                foreach (var item in data)
                {
                    if (number == item.User)
                    {
                        Console.WriteLine("Hra: " + item.Type + "   " + " Mapa: " + item.Map + "    " + " Score usera bylo:" + item.Score);
                    }
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data.Count == sum)
                        {
                            Console.WriteLine(sum + item.Type);
                        }
                    }
                }
            }
        }
        public List<Item> GetData()
        {
            var output = new List<Item>();
            using var ar = new StreamReader("./input.txt");

            var line = string.Empty;
            while ((line = ar.ReadLine()) != null)
            {
                var splitted = line.Split(';');
                output.Add(new Item
                {
                    Id = splitted[0],
                    User = splitted[1].Trim().ToLower(),
                    Type = splitted[2].Trim().ToLower(),
                    Map = splitted[3].Trim().ToLower(),
                    Rate = splitted[4].Trim().ToLower(),
                    KD = splitted[6].Trim().ToLower(),
                    Score = splitted[5].Trim().ToLower(),
                    Minute = splitted[7].Trim().ToLower(),
                });
            }
            return output;
        }

    }
}
