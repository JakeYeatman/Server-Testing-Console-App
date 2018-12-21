using System;
using System.Collections.Generic;
using System.Text;
using ServerTesterApplication.ExternalAPIConnections;

namespace ServerTesterApplication
{
    class Menu
    {
        bool loop = true;
        public void Run()
        {
            while (loop)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("=================================");
                Console.WriteLine("= Server Tester Application v.1 =");
                Console.WriteLine("=================================");
                Console.WriteLine("=     [API] to Test the API     =");
                Console.WriteLine("=     [CAZ] to Test the Cazana  =");
                Console.WriteLine("=     [Q] to Quit               =");
                Console.WriteLine("=================================");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "API":
                        RDSAPI_Test.TestANPR();
                        break;
                    case "CAZ":
                        CazanaValuation.GetCarValuation("CE08EEZ");
                        break;
                    case "q":
                    case "Q":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
