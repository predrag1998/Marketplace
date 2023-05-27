using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Models.CustomDataAnnotation
{
    public class RangeCurrentYear : RangeAttribute
    {
        public RangeCurrentYear(double minimum) : base(minimum, DateTime.Now.Year)
        {
        }
    }
}
