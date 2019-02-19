using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class OrdersModel
    {
        public int OrderId { get; set; }
        public float Pay { get; set; }
        public DateTime Time { get; set; }
        public int State { get; set; }
        public int UserId { get; set; }
    }
}
