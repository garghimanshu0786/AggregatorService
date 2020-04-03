using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService
{
    public class OrderDetails
    {
        public User User { get; set; }

        public List<Order> Orders { get; set; }
    }
}
