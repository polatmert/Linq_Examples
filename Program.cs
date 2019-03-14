using System;
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

            Console.ReadLine();
        }
    }
}
