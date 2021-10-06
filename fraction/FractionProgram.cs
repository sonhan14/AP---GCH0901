using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fraction
{
    public class FractionProgram : MenuProgram
    {
        protected override void PrintMenu()
        {
            Console.WriteLine();

            Console.WriteLine("1: Add Fractions");
            Console.WriteLine("2: Subtract Fractions");
            Console.WriteLine("3: Multiply Fractions");
            Console.WriteLine("4: Divide Fractions ");
            Console.WriteLine("0: Exit");
        }
        protected override void DoTask(int option)
        {
        switch(option)
            {
                case 1: Add2Fractions();        break;
                case 2: Sub2Fractions();        break;
                case 3: Mul2Fractions();        break;
                case 4: Div2Fractions();        break;
                case 0: Quit();                 break;
                default: ShowError();           break;
            }
        }

        private void ShowError()
        {
            System.Console.WriteLine("Invalid option!");
        }

        private void Quit()
        {
            System.Console.WriteLine("Exit program");
        }
        private void Div2Fractions()
        {
            Fraction f1 = Enter("Enter 1st");
            Fraction f2 = Enter("Enter 2st");
            System.Console.WriteLine(f1.Div(f2));
        }

        private void Mul2Fractions()
        {
            Fraction f1 = Enter("Enter 1st");
            Fraction f2 = Enter("Enter 2st");
            System.Console.WriteLine(f1.Mul(f2));
        }

        private void Sub2Fractions()
        {
            Fraction f1 = Enter("Enter 1st");
            Fraction f2 = Enter("Enter 2st");
            System.Console.WriteLine(f1.Sub(f2));
        }

        private void Add2Fractions()
        {
            Fraction f1 = Enter("Enter 1st");
            Fraction f2 = Enter("Enter 2st");
            System.Console.WriteLine(f1.Add(f2));
        }

        public Fraction Enter(String prompt)
        {
            Fraction f = new Fraction();
            while(true)
            {
                try
                {
                    System.Console.Write(prompt + " numerator fraction: ");
                    f.Numerator = Convert.ToInt32(Console.ReadLine());
                    System.Console.Write(prompt + " denominator fraction: ");
                    f.Denominator = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    System.Console.WriteLine(e.Message);
                }
                catch (DenominatorisZeroException e)
                {
                    System.Console.WriteLine(e.Message);
                } 
            }            
            return f;
        }
    }
}