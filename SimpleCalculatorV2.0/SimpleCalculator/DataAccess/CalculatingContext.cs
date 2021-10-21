using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.DataAccess
{
    public class CalculatingContext:DbContext
    {
        public DbSet<CalculatorRecord> CalculatorRecords { get; set; }
    }
}
