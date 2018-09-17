using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firsthandin
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer standard = new Customer();
            Console.WriteLine("Default " + standard + "\n");

            Customer custom = new Customer("Jan", "Rasmussen", 74, 6800, "123123123");
            Console.WriteLine("Custom " + custom + "\n");

            custom.ResetPassword("987987987");

            Console.WriteLine("Custom " + custom + "\n");
        }
    }
}
