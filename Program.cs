using System;
using RomanToInt.RomToInt;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            runConverter();
        }

        static void runConverter()
        {

            //Declares Class that converts from Decimal To Roman
            InToRo2 dtr = new InToRo2();

            //Draws line
            drawLine();
            Console.Write("Number: ");

            //Checks if it Decimal Number
            int num = checkValidator(Console.ReadLine());
            if (num > 0)
            {
                drawLine();

                Console.WriteLine(dtr.intToRoman(num));
                Console.WriteLine(""); drawLine();


                RoToIn rti = new RoToIn();

                Console.Write("Insert Roman number: ");
                string RNumber = Console.ReadLine().ToUpper();
                
                
                if (checkVaLetters(RNumber))
                {   
                    string romanString = rti.romanToDecimal(RNumber).ToString();

                    drawLine();
                    Console.Write("Int number: ");
                    Console.WriteLine(romanString);
                    drawLine();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter letters only!");
                }
                
            }

        }


        //Vlaidates if string is number
        static int checkValidator(string container)
        {

            int num = 0;
            try
            {
                
                if (Regex.IsMatch(container, @"^\d+$"))
                {
                    num = Convert.ToInt32(container);
                    //Console.WriteLine("Given string is numeric");

                    if (num >= 1000)
                    {
                        Console.WriteLine("Out side range. Please enter number less than 1000");

                    }
                    else if (num <= 0)
                    {
                        Console.WriteLine("Please enter number greater than 0");
                    }
                }
                else
                {
                    Console.WriteLine("Given string is non-numeric");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return num;
        }

        //Validate if string is letter
        static bool checkVaLetters(string container)
        {

            bool conIsString = false;
            try
            {

                if (Regex.IsMatch(container, @"^[a-zA-Z]+$"))
                {
                    conIsString = true;
                }                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return conIsString;
        }

        //draws the line
        static void drawLine()
        {
            int i = 0;
            while (i < 30)
            {
                Console.Write("-");
                i++;
            }
            Console.WriteLine("");
        }

    }
}
