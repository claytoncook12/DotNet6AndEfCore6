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
            People person = new People()
            {
                FirstName = "Test",
                LastName = "Last"
            };
            context.People.Add(person);

            ParentGroup group = new ParentGroup()
            {
                GroupTitle = "NewGroup"
            };
            context.ParentGroups.Add(group);

            context.SaveChanges();
            Console.WriteLine("Finished Database Operations");
        }
    }
}