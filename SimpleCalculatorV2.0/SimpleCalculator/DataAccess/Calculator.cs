using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.DataAccess
{
    public class CalculatorRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //设置自增
        public int Id { get; set; }

        public double FirstNumber { get; set; }

        public double SecondNumber { get; set; }

        public string Operator { get; set; }

        public double Result { get; set; }

        public DateTime OperateDateTime { get; set; }
    }
}
