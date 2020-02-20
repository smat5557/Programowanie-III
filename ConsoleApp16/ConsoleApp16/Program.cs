using System;
using System.IO;
using System.Linq;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                var lines = File.ReadAllLines("TextFile.txt");

                var people = lines.Select(x =>

                {

                    var data = x.Split(',');

                    return new Person(

                        Convert.ToInt32(data[0]),

                        data[1],

                        data[2],

                        data[3]);

                });



                var sortedPeople = people

                    .OrderBy(x => x.Surname)

                    .ThenBy(x => x.Name);

                using StreamWriter writer = new StreamWriter("result.txt");



                foreach (var item in sortedPeople)

                {

                    writer.WriteLine($"[{item.Name}] {item.Name} {item.Surname} {item.Phone}");

                }



            }

        }

    }
}