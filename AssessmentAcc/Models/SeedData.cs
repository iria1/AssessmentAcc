using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AssessmentAcc.Data;
using System;
using System.Linq;

namespace AssessmentAcc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AssessmentAccContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AssessmentAccContext>>()))
            {
                // Look for any movies.
                if (context.Customers.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customers.AddRange(
                    new Customers
                    {
                        TipeCustomer = "Perusahaan",
                        Nama = "Company 1",
                        NomorTelp = "0123456789",
                        Alamat = "Jl Hatiku Senang",
                        NomorRekening = "0123456789"
                    },

                    new Customers
                    {
                        TipeCustomer = "Perusahaan",
                        Nama = "Company 2",
                        NomorTelp = "0123456789",
                        Alamat = "Jl Hatiku Senang",
                        NomorRekening = "0123456789"
                    },

                    new Customers
                    {
                        TipeCustomer = "Perorangan",
                        Nama = "Person 1",
                        NomorTelp = "0123456789",
                        Alamat = "Jl Hatiku Senang",
                        NomorRekening = "0123456789"
                    },

                    new Customers
                    {
                        TipeCustomer = "Perorangan",
                        Nama = "Person 2",
                        NomorTelp = "0123456789",
                        Alamat = "Jl Hatiku Senang",
                        NomorRekening = "0123456789"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
