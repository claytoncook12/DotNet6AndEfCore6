﻿using Microsoft.EntityFrameworkCore;
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

            // Add People Data
            //var person1 = new People()
            //{
            //    FirstName = "Clayton",
            //    LastName = "Cook"
            //};
            //context.People.Add(person1);

            // Add ParentGroup
            //var parentGroup1 = new ParentGroup()
            //{
            //    GroupTitle = "Group1000"
            //};
            //context.ParentGroups.Add(parentGroup1);

            // Add People to ParentGroup
            //var existingParentGroup = context.ParentGroups
            //    .SingleOrDefault(x => x.GroupTitle == "Group1000");
            //var person = context.People.SingleOrDefault(x => x.PersonId == 1);
            //if (existingParentGroup != null && person != null)
            //{
            //    existingParentGroup.Peoples.Add(person);
            //}

            // Remove People From ParentGroup
            //var existingParentGroup = context.ParentGroups
            //    .Include(x => x.Peoples)
            //    .SingleOrDefault(x => x.GroupTitle == "Group1000");
            //var person = context.People.SingleOrDefault(x => x.PersonId == 1);
            //if (existingParentGroup != null && person != null)
            //{
            //    bool success = existingParentGroup.Peoples.Remove(person);
            //    if (success)
            //    {
            //        Console.WriteLine("Found Person to Remove in Parent Group");
            //    }
            //}

            context.SaveChanges();

            Console.WriteLine("Finished Database Operations");
        }
    }
}