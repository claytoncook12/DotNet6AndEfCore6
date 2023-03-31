using System;
using TestingNet6EFCore6.Data;
using TestingNet6EFCore6.Models;

namespace TestingNet6EFCore6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SetUp Connection
            DatabaseContext context = new DatabaseContext();

            // Add Data


            Console.WriteLine("Finished Database Operations");
        }
    }
}