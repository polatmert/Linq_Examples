﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************************************************************************//

            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var numberList = from n1 in number  // connection
            //                 where n1 > 4       // conditions
            //                 select n1;         //values

            //Console.WriteLine("Numbers greater than 4");

            //foreach(var values in numberList)
            //{
            //    Console.WriteLine("Number : {0} " , values);
            //}

            //*********************************************************************************************//

            //int[] numbers1 = { 1, 3, 5, 7, 9 };
            //int[] numbers2 = { 1, 5, 8, 7, 22 };

            //var control = from list1 in numbers1
            //              from list2 in numbers2
            //              where list1 < list2
            //              select new { list1, list2 }; //anonim type = temp

            //Console.WriteLine("List Comparison");

            //foreach (var item in control)
            //{
            //    Console.WriteLine("Result  {0} < {1} " ,item.list1 , item.list2);
            //}

            //*********************************************************************************************//

            //int[] numbers3 = { 2, 1, 4, 6, 12, 87, 3, 9, 0 };

            //var numberAdd = from list in numbers3
            //                select list + 5;

            //Console.WriteLine("New Values");

            //foreach (var item in numberAdd)
            //{

            //    Console.WriteLine("new values  - > {0}", item);
            //}

            //*********************************************************************************************//


            //string[] list = { "ApPle", "cAR", "CoMPuTEr" };

            //var edit = from l1 in list
            //              select new { Upper = l1.ToUpper(), lower = l1.ToLower() };

            //foreach (var item in edit)
            //{
            //    Console.WriteLine("Upper - >>>{0}  Lower- >>>{1}", item.Upper, item.lower);
            //}

            //*********************************************************************************************//

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //var firstFourNumber = numbers.Take(4);
            //Console.WriteLine("First Four Number ");

            //foreach (var item in firstFourNumber)
            //{
            //    Console.WriteLine("Values {0}" ,item);
            //}

            //*********************************************************************************************//

            //int[] numbers = { 1, 2, 3, 4, 5, 67, 8, 9, 12 };

            //var  newList = numbers.Skip(5);
            //Console.WriteLine("New List");

            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************************************//

            //int[] numbers = { 123,222, 13, 499, 52, 6423, 722 };


            //var shotList = from sN in numbers
            //               orderby sN
            //               select sN;

            //Console.WriteLine("Short List");

            //foreach (var item in shotList)
            //{
            //    Console.WriteLine("Values : {0}" , item);
            //}


            //*********************************************************************************************//


            //string [] cities = { "izmir", "ankara", "antalya", "Bursa" };

            //var list = from ct in cities orderby ct.Length descending select ct;

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************************************//


            //int[] listInt = { 1, 2, 2, 3, 4, 55, 6, 7, 7, 8, 1, 2 };

            //var diff = listInt.Distinct();

            //foreach (var item in diff)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************************************//

            //int[] list1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] list2 = { 1, 2, 32, 43, 2, 4, 5, 6 };

            //var Union = list1.Union(list2);

            //foreach (var item in Union)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************************************//

            //int[] list1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] list2 = { 1, 2, 32, 43, 2, 4, 5, 6 };

            //var intersect = list1.Intersect(list2); 

            //foreach (var item in intersect)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************************************//

            //list1 difference list2
            //int[] list1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] list2 = { 11, 2, 32, 43, 2, 4, 5, 6 };

            //IEnumerable<int> numbers = list1.Except(list2);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************************************//

            //object[] list = { "one", null, "two", 3.3, "pazartesi", "monday", 1.7};

            //var doubleNumbers = list.OfType<double>();

            //foreach (var item in doubleNumbers)
            //{
            //    Console.WriteLine("Double values : {0}", item);
            //}

            //*********************************************************************************************//

            //var numbers = from s in Enumerable.Range(1, 50)
            //              select new { number = s, tekSayi = s % 2 == 1 ? "Single" : "Even" };

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);

            //}

            //*********************************************************************************************//

            //int[] numbers = { 2, 4, 6, 8, 10, 12 };
            ////return bool type 
            //bool cift = numbers.All(s => s % 2 == 0);
            //Console.WriteLine("cift  ? = > {0}", cift);

            //*********************************************************************************************//

            //string[] list = { "sta", "stack", "stackover", "stackoverflow" };
            //bool flag = list.Any(x => x.Contains("sta"));
            //Console.WriteLine(flag);

            //*********************************************************************************************//

            int[] list = { 1, 2, 3, -5, 5, 3, 2, 3, 4, 53, 6 };
            int[] list2 = { 1,2, 111, 222, 323 };


            Console.WriteLine("Count = {0} " , list.Distinct().Count());
            Console.WriteLine("Sum = {0} ", list.Distinct().Sum());
            Console.WriteLine("Max = {0} ", list.Max());
            Console.WriteLine("Min = {0} ", list.Min());
            Console.WriteLine("Avarage = {0}", list.Average());

            var newList = list.Concat(list2);
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            bool flag = list.SequenceEqual(list2);
            
            //*********************************************************************************************//

            Console.ReadLine();
        }
    }
}
