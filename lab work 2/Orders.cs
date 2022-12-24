using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Orders
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public DateTime DateOfAdmission { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int UserID { get; set; }
        public int ServiceID { get; set; }
    }
}
