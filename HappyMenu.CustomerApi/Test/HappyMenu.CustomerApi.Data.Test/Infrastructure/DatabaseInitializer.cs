﻿using HappyMenu.CustomerApi.Data.Database;
using HappyMenu.CustomerApi.Domain.Entities;
using System;
using System.Linq;

namespace CustomerApi.Data.Test.Infrastructure
{
    public class DatabaseInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            if (context.Customer.Any())
            {
                return;
            }

            Seed(context);
        }

        private static void Seed(CustomerContext context)
        {
            var customers = new[]
            {
                new Customer
                {
                    Id = Guid.Parse("9f35b48d-cb87-4783-bfdb-21e36012930a"),
                    FirstName = "Yang",
                    LastName = "Li",
                    Birthday = new DateTime(1989, 11, 23),
                    Age = 30
                },
                new Customer
                {
                    Id = Guid.Parse("654b7573-9501-436a-ad36-94c5696ac28f"),
                    FirstName = "Darth",
                    LastName = "Vader",
                    Birthday = new DateTime(1977, 05, 25),
                    Age = 42
                },
                new Customer
                {
                    Id = Guid.Parse("971316e1-4966-4426-b1ea-a36c9dde1066"),
                    FirstName = "Han",
                    LastName = "Solo",
                    Birthday = new DateTime(737, 04, 16),
                    Age = 1282
                }
            };

            context.Customer.AddRange(customers);
            context.SaveChanges();
        }
    }
}