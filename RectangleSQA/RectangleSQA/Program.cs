using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleSQA
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SelectOption();
            Console.ReadKey();

        }
        public void SetValues()
        {
            Rectangle rec;
            int len;
            do
            {
                Console.WriteLine("Please enter the length");
            } while (!int.TryParse(Console.ReadLine(), out len) || len <= 0);
            //{ Console.WriteLine("The value has to be a positive integer, please enter again."); }
            int wid;
            do
            {
                Console.WriteLine("Please enter the width");
            } while (!int.TryParse(Console.ReadLine(), out wid) || wid <= 0);
            //{ Console.WriteLine("The value has to be a positive integer, please enter again."); }
            rec = new Rectangle(len, wid);
        }
        public void SelectOption()
        {
            Rectangle rec;
            int length;
            do
            {
                Console.WriteLine("Please enter the length");
            } while (!int.TryParse(Console.ReadLine(), out length) || length <= 0);
            //{ Console.WriteLine("The value has to be a positive integer, please enter again."); }
            int width;
            do
            {
                Console.WriteLine("Please enter the width");
            } while (!int.TryParse(Console.ReadLine(), out width) || width <= 0);
            //{ Console.WriteLine("The value has to be a positive integer, please enter again."); }
            rec = new Rectangle(length, width);

            int exitSelect = 0;
            do
            {
                int selection = 0;
                do
                {
                    Console.WriteLine("Please select one option from following options");
                    Console.WriteLine("1. Get Rectangle Length");
                    Console.WriteLine("2. Change Rectangle Length");
                    Console.WriteLine("3. Get Rectangle Width");
                    Console.WriteLine("4. Change Rectangle Width");
                    Console.WriteLine("5. Get Rectangle Perimeter");
                    Console.WriteLine("6. Get Rectangle Area");
                    Console.WriteLine("7. Exit");
                } while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection > 7);
                //{ Console.WriteLine("Invalid input, please select from the given numbers."); }
                exitSelect = selection;

                if (selection == 1)
                {
                    Console.WriteLine("The length is {0}", rec.GetLength());
                }
                if (selection == 2)
                {
                    int len;
                    do
                    {
                        Console.WriteLine("Please enter the length");
                    } while (!int.TryParse(Console.ReadLine(), out len) || len < 1);
                    //{ Console.WriteLine("The value has to be a positive integer and greater than 1, please enter again."); }
                    rec.SetLength(len);
                    Console.WriteLine("The length has been set as {0}", rec.Length);
                }
                if (selection == 3)
                {
                    rec = new Rectangle();
                    Console.WriteLine("The width is {0}", rec.GetWidth());
                }
                if (selection == 4)
                {
                    int wid = 0;
                    do
                    {
                        Console.WriteLine("Please enter the width");
                        
                    } while (!int.TryParse(Console.ReadLine(), out wid) || wid < 1);
                    //{ Console.WriteLine("The value has to be a positive integer and greater than 1, please enter again."); }
                    rec.SetWidth(wid);
                    Console.WriteLine("The width has been set as {0}", rec.Width);
                }
                if (selection == 5)
                {
                    Console.WriteLine("The perimeter of the rectangle is {0}", rec.GetPerimeter());
                }
                if (selection == 6)
                {
                    Console.WriteLine("The area of the rectangle is {0}", rec.GetArea());
                }
                else if(selection == 7)
                {
                    Console.WriteLine("Thank you, have a nice day");
                }
            } while (exitSelect != 7);
            
        }
    }
}
