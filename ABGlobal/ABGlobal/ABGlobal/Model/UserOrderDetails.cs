using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABGlobal.Model
{
    public class UserOrderDetails
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public UserOrderDetails()
        { }
    }
}
