using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssessmentAcc.Models;

namespace AssessmentAcc.Data
{
    public class AssessmentAccContext : DbContext
    {
        public AssessmentAccContext (DbContextOptions<AssessmentAccContext> options)
            : base(options)
        {
        }

        public DbSet<AssessmentAcc.Models.Transactions> Transactions { get; set; }

        public DbSet<AssessmentAcc.Models.Customers> Customers { get; set; }

        public DbSet<AssessmentAcc.Models.ItemTransactions> ItemTransactions { get; set; }
    }
}
