using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGlobal.Model
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDetail { get; set; }
        public int OrderQuantity { get; set; }
    }
}
