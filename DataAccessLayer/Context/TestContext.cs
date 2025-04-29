using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class TestContext:DbContext
    {
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Wage> Wages { get; set; }
    }
}
