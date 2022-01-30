using AssignmentException.NUMBER8;
using System;
using System.IO;
using System.Net;

namespace AssignmentException
{
    class Program
    {
        static void Main(string[] args)
        {
            AllNumber();

        }
        public static void AllNumber()
        {
            Console.WriteLine("7.Number7\n"+"8.Number8\n"+"9.Number9");
            while (true)
            {
                Console.Write("Qustion: ");
                int respond = int.Parse(Console.ReadLine());
                if (respond == 7)
                {
                    number7();
                }
                else if (respond == 8)
                {
                    Number8();
                }
                else if (respond == 9)
                {
                    Number9();
                }
                else
                {
                    break;
                }
            }

        }
        public static void number7()
        {
            try
            {
                Console.Write("enter a number: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new Invalidnumberexpression("invalid number!!");
                }
                else
                {
                    double sq = Math.Sqrt(num);
                    Console.WriteLine(sq);
                }
            }
            catch(Invalidnumberexpression ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(System.FormatException am)
            {
                Console.WriteLine(am.Message);
            }
            finally
            {
                Console.WriteLine("good bye!!");
            }
            
        }
        public static void Number8()
        {          
            
            try
            {
                int previous = 0;
                for (int i=0;i<10; i++)
                {
                  
                    Console.Write("enter number:");
                    int num = int.Parse(Console.ReadLine());                   
                    if (num >previous )
                    {
                        previous = num;
                    }
                    else if(num<previous)
                    {
                        throw new Invalidnumberexpression("greater!!");
                    }
                    
                    
                }
            }
            catch(Invalidnumberexpression e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Number9()
        {
            FileText.Files();
        }
        
    }
}
