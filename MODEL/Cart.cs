using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductHeadPath { get; set; }
        public float ProductPrice { get; set; }
        public int Number { get; set; }
        public float Pay { get; set; }
        public int UsersId { get; set; }

    }
}
