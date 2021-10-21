using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Domain
{
    public class CalculatorRecordDTO
    {
        public int Id { get; set; }

        public double FirstNumber { get; set; }

        public double SecondNumber { get; set; }

        public string Operator { get; set; }

        public double Result { get; set; }

        public string OperateDateTime { get; set; }
    }
}
