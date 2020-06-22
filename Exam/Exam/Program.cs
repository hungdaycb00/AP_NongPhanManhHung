﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> arrProduct = new List<Product>();
            Book bk1 = new Book(1, "Book1", 99.99, "ABC");
            Book bk2 = new Book(2, "Book2", 10.99, "ABC");
            Book bk3 = new Book(3, "Book3", 20.99, "ABC");
            MobilePhone mb1 = new MobilePhone(4, "Iphone 3", 999.99, "Apple");
            MobilePhone mb2 = new MobilePhone(5, "Iphone 4", 1999.99, "Apple");
            MobilePhone mb3 = new MobilePhone(6, "Iphone 5", 2999.99, "Apple");

            arrProduct.Add(bk1);
            arrProduct.Add(bk2);
            arrProduct.Add(bk3);
            arrProduct.Add(mb1);
            arrProduct.Add(mb2);
            arrProduct.Add(mb3);
            Console.WriteLine(arrProduct.Count);
            double totalBookTax = 0;

            double totalMobileTax = 0;
            double totalTax = 0;
            
            for (int i = 0; i < arrProduct.Count; i++)
            {
                if(arrProduct[i].Id <= 3)
                {
                    totalBookTax += arrProduct[i].ComputeTax();
                }
                else
                {
                    totalMobileTax += arrProduct[i].ComputeTax();
                }
                
            }
            Console.WriteLine("Total book tax: " + totalBookTax);
            Console.WriteLine("Total mobile tax: " + totalMobileTax);
            totalTax = totalBookTax + totalMobileTax;
            Console.WriteLine("Total Tax is: " + totalTax);
            Console.ReadKey();

        }
    }
}
