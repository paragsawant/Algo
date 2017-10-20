using ABGlobal.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ABGlobal
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://cc.davelozinski.com/c-sharp/fastest-way-to-read-text-files
            Dictionary<int, UserOrderDetails> _userDetails = new Dictionary<int, UserOrderDetails>();
            //reading user details csv and adding that to dictonary
            int userCount = 0;
            string userDetailsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"File\UserDetails.csv");
            string orderDetailsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"File\OrderDetails.csv");
            bool isUserDetailsHeader = true;
            foreach (var line in File.ReadLines(userDetailsPath))
            {
                if (isUserDetailsHeader)
                {
                    isUserDetailsHeader = false;
                    continue;
                }

                string[] lineDetails = line.Split(',');
                ++userCount;
                var theLine = new UserOrderDetails()
                {
                    UserId = Convert.ToInt32(lineDetails[0]),
                    UserName = lineDetails[1],
                    RegistrationDate = Convert.ToDateTime(lineDetails[2]),
                    OrderDetails = new List<OrderDetails>()
                };
                _userDetails.Add(theLine.UserId, theLine);
            }
            bool isOrderDetailsHeader = true;
            int orderCount = 0;
            foreach (var line in File.ReadLines(orderDetailsPath))
            {
                if (isOrderDetailsHeader)
                {
                    isOrderDetailsHeader = false;
                    continue;
                }

                string[] lineDetails = line.Split(',');
                ++orderCount;
                UserOrderDetails userDetails = new UserOrderDetails();
                if (_userDetails.ContainsKey(Convert.ToInt32(lineDetails[0])))
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.OrderId = Convert.ToInt32(lineDetails[1]);
                    orderDetails.OrderDetail = lineDetails[3];
                    orderDetails.OrderDate = Convert.ToDateTime(lineDetails[2]);
                    orderDetails.OrderQuantity = Convert.ToInt32(lineDetails[4]);
                    _userDetails[Convert.ToInt32(lineDetails[0])].OrderDetails.Add(orderDetails);
                }
            }
        }
    }
}
