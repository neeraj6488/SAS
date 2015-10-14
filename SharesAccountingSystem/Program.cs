using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharesBusiness;

namespace SharesAccountingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandNumber;
            MemberUI memberUI = new MemberUI();

            WriteApplicationBanner();
            commandNumber = WriteCommands();

            do
            {
                if (commandNumber==4)
                {
                    break;
                }

                switch (commandNumber)
                {
                    case 1:
                        memberUI.AddNew();
                        break;
                    case 3:
                        memberUI.GetAll();
                        break;
                    default:
                        Console.WriteLine("Invalid Command...!!!");
                        break;
                }

                commandNumber = WriteCommands();

            } while (commandNumber != 4);

            Console.WriteLine("=============================================================================\n");
            Console.WriteLine("******************************** Thank You **********************************\n");
            Console.WriteLine("=============================================================================\n");

            Console.ReadKey();
        }

        static void WriteApplicationBanner()
        {
            Console.WriteLine("=============================================================================\n");
            Console.WriteLine("  ************** Welcome to New Paramatrix Co-operative Bank **************\n");
            Console.WriteLine("=============================================================================\n");
        }

        static int WriteCommands()
        {
            int commandNumber;

            Console.WriteLine("1. Add New Customer\n");
            Console.WriteLine("2. Delete Customer\n");
            Console.WriteLine("3. View All Customers\n");
            Console.WriteLine("4. Exit the Program\n");
            Console.Write("Select Command (enter command number): ");
            commandNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=============================================================================\n");

            return commandNumber;
        }
    }
}

