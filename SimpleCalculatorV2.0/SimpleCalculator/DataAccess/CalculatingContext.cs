using SimpleCalculator.Domain;
using System.Data.Entity;

namespace SimpleCalculator.DataAccess
{
    public class CalculatingContext : DbContext
    {
        public DbSet<CalculatorRecord> CalculatorRecords { get; set; }
    }
}
