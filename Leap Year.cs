using System;
namespace App {
    class Program {
        static void Main(string[] args) {
            int year;
            Console.Write("Enter any year: ");
            year = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The next 20 leap years from the given year " + year + " are: ");
            int count = 0;
            while(count != 20){
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
                    Console.WriteLine(year);
                    count++;
                }
                year++;
            }
        }
    }
}
