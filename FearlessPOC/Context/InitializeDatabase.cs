using FearlessPOC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FearlessPOC.Context
{
    public class InitializeDatabase
    {
        /// <summary>
        /// Seeds database with test data
        /// </summary>
        /// <param name="serviceProvider"></param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                // Look for any board games.
                if (context.Items.Any())
                {
                    return;   // Data was already seeded
                }

                context.Items.AddRange(
                    new Item
                    {
                        Id = 1,
                        Name = "Purple Cow"
                    },
                    new Item
                    {
                        Id = 2,
                        Name = "Test Name"
                    });

                context.SaveChanges();
            }
        }
    }
}
