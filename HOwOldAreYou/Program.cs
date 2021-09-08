using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab kasutaja sünniaastat konsooli
            Console.WriteLine("Tere, kui vana te olete");
            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;

            Console.WriteLine("oled sündinud aastal " + YearOfBirth);
            //Teine võimalus-Console.Writeline($"Oled sündinud aastal {YearOfBirth.")
        }
    }
}
