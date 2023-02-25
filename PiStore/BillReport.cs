using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStore
{
    class BillReport
    {
        public string pid { get; set; }
        public string p_name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        public DateTime createdAt { get; set; }
        public int total { get; set; }

        public string acc_id { get; set; }
    }
}
