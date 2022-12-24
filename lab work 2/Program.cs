using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (OrdersContext db = new OrdersContext())
            {
                var orders = from order in db.Orders
                             join user in db.Users on order.UserID equals user.ID
                             join service in db.Services on order.ServiceID equals service.ID
                             select new
                             {
                                 ONumber = order.Number,
                                 OPrice = order.Price,
                                 ODateAd = order.DateOfAdmission,
                                 ODateIs = order.DateOfIssue,
                                 UFirst = user.FirstName,
                                 ULast = user.LastName,
                                 UMiddle = user.MiddleName,
                                 SName = service.ServiceName
                             };
                Console.WriteLine("{0,12} {1,7} {2,20} {3,20} {4,17} {5,17} {6,17} {7,17}\n", "Number", "Price", "Date of addmission", "Date of issue", "LastName", "FirstName", "MiddleName", "ServiceName");
                foreach (var order in orders)
                {
                    Console.WriteLine("{0,-30} {1,-15} {2,-20} {3,-15}", order.ONumber, order.OPrice, order.ODateAd, order.ODateIs, order.ULast, order.UFirst, order.UMiddle, order.SName);
                }
            }
            Console.Read();
        }
    }
}
