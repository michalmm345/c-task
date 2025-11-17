using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {



        static void checkNum()
        {
            int num;
            Console.WriteLine("please enter number");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("the number is positive");
                if (num % 2 == 0)
                    Console.WriteLine("the number is an even number ");
                else Console.WriteLine("the number is an odd number");
            }
            else if (num == 0)
                Console.WriteLine("zero");
            else Console.WriteLine("the number is negative");

        }
        static void electricty()
        {
            int usuage;
            double payment;
            bool isBusiness;
            double total;
            Console.WriteLine("is it a business?");
            isBusiness = bool.Parse(Console.ReadLine());
            Console.WriteLine("please enter usuage");
            usuage = int.Parse(Console.ReadLine());

            if (usuage <= 300)

                payment = 0.5 * usuage;


            else if (usuage <= 600)

                payment = 0.7 * usuage;

            else

                payment = usuage;


            if (isBusiness == false)
              
                total = payment+payment*5/100;

            else total = payment+payment*15/100;

            Console.WriteLine("you need to pay:" + total);



        }
        static void task3()
        {
            bool isCity;
            string passangerType;
            int price;
            double totalPrice;
            string type1 = "student";
            string type2 = "eldery";

            Console.WriteLine("is it a city?");
            isCity = bool.Parse(Console.ReadLine());
            Console.WriteLine("what is the passanger type?");
            passangerType = Console.ReadLine();

            if (isCity == false)
                price = 6;
            else price = 12;

            if (passangerType.Equals(type1))
                totalPrice = price - price * 0.2;
            else if (passangerType.Equals(type2))
                totalPrice = price - price * 0.3;
            else totalPrice = price;
            Console.WriteLine("you need to pay:" + totalPrice);
        }

        static void task4()
        {
            int age;
            string status;
            double basePrice;
            double total;
            string status1 = "student";
            string status2 = "VIP";
            string status3 = "IDF";



            Console.WriteLine("how old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("what are you?");
            status = Console.ReadLine();

           if (age <= 18)
                basePrice = 120;
           else  if (age >= 60)
             basePrice = 180;
           else basePrice = 150;

         if (status.Equals(status1))
              total = basePrice - basePrice * 0.2;
      
         else if (status.Equals(status2))
              total = basePrice + basePrice * 0.3;

         else if (status.Equals(status3))
              total = basePrice - basePrice * 0.15;
         else total = basePrice;
         
            
          Console.WriteLine("you need to pay:"+total);


                
        }
            static void Main(string[] args)
            {

                checkNum();
                electricty();
                task3();
                task4();


            }
        }
    }