using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_DataTypesAndVariables_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("Number x is " + x);
            //Change on the fly
            x = 5;
            Console.WriteLine("Number x is " + x);

            double dbl_num = 0.0d;
            float flt_num = 0.0f;
            decimal dcml_num = 0.0m;

            dbl_num = 1.1d;
            flt_num = 2.2f;
            dcml_num = 3.3m;

            Console.WriteLine("Double variable = " + dbl_num);
            Console.WriteLine("Float variable = " + flt_num);
            Console.WriteLine("Decimal variable = " + dcml_num);

            string firstName, lastName, house;
            firstName = "Jon";
            lastName = "Snow";
            house = "Stark";

            Console.WriteLine("You know nothing... " + firstName + " " + lastName + " of " + house);

        }
    }
}
