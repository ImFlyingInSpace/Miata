using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miata
{
    class App
    {
        public void Run()
        {
            double fuel = 0.0669;
            bool running = true;
            while (running)
            {
                Console.WriteLine("history/new record");
                var input = Console.ReadLine();
                if (input == "history")
                {
                    var sr = new StreamReader("./history.txt");
                    var read = sr.ReadToEnd();
                    Console.WriteLine(read);
                    sr.Close();
                    continue;
                }
                else if (input == "new record")
                {
                    Console.WriteLine("please insert price for 1l of fuel:");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("please insert distance in km:");
                    double distance = Convert.ToDouble(Console.ReadLine());
                    double allfuel = fuel * distance;
                    double fullprice = price * allfuel;
                    Console.WriteLine("you consumed "+allfuel+"l of fuel");
                    Console.WriteLine("you spended "+fullprice);
                    var sw = new StreamWriter("./history.txt", true);
                    sw.WriteLine(allfuel + "l ; " + fullprice + ",- ; " + distance + "km");
                    sw.Close();
                    continue;
                }
                else if(input == "exit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
