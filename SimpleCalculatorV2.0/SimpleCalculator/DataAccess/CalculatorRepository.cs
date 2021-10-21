using SimpleCalculator.Domain;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator.DataAccess
{
    public class CalculatorRepository
    {
        public void SaveCalculator(CalculatorRecord calculator)
        {
            using (CalculatingContext dbContext = new CalculatingContext())
            {
                dbContext.CalculatorRecords.Add(calculator);
                dbContext.SaveChanges();
            }
        }

        public bool DeleteCalculator(int Id)
        {
            using (CalculatingContext dbContext = new CalculatingContext())
            {
                CalculatorRecord calculatorRecord = dbContext.CalculatorRecords.Find(Id);
                if (calculatorRecord != null)
                {
                    dbContext.CalculatorRecords.Remove(calculatorRecord);
                    dbContext.SaveChanges();
                    return true;
                }
                else { return false; }
            }
        }

        public List<CalculatorRecord> QueryAllCalculatorRecord()
        {
            using (CalculatingContext db = new CalculatingContext())
            {
                var query = from record in db.CalculatorRecords orderby record.Id select record;
                return query.ToList();
            }
        }
    }
}
