using System;
using static LinkedlistApp.LinkedListHelpers;
namespace LinkedlistApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRepeatedTimes = 2;
            /*Add values to linked list*/
            AddNodeEnd("E");
            AddNodeEnd("B");
            AddNodeEnd("E");
            AddNodeEnd("E");
            AddNodeEnd("B");
            AddNodeEnd("A");
            AddNodeEnd("B");

            //AddNodeEnd("A");
            //AddNodeEnd("A");
            //AddNodeEnd("B");
            //AddNodeEnd("Z");
            //AddNodeEnd("Z");
            //AddNodeEnd("Z");
            //AddNodeEnd("Q");
            //AddNodeEnd("Z");
            //AddNodeEnd("A");
            //AddNodeEnd("A");
            //AddNodeEnd("Y");
            //AddNodeEnd("M");
            //AddNodeEnd("U");
            //AddNodeEnd("Y");
            //AddNodeEnd("Y");

            /*print currently existing values in linked list*/
            Console.WriteLine("Print Existing values of nodes in linked list");
            PrintList();

            /*print values of linked  list after deleting node*/
            Console.WriteLine($"Print Values after deleting Nodes with values that are repeated more than {maxRepeatedTimes} times.!");

            DeleteRepeatValues(maxRepeatedTimes);
            PrintList();

            Console.ReadKey();
        }
    }






}
