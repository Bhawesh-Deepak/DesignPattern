using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class OfflineProduct : ProcessOrder
    {
        public override void CreateInvoice()
        {
            Console.WriteLine("Create Invoice for offline Store");
        }

        public override void CreatePackageForProduct()
        {
            Console.WriteLine("Create Package for offline Store");
        }

        public override void DecreaseProductQuantityFromInventory()
        {
            Console.WriteLine("Decrease Product Quantity for offline Store");
        }

        public override void DelivertheProduct()
        {
            Console.WriteLine("Deliver the Product to Customer Address offline");
        }

        public override void GetProductDetails()
        {
            Console.WriteLine("Get Product details for offline Store");
        }

        public override void PaymentForProduct()
        {
            Console.WriteLine("Get Product details for offline Store");
        }
    }
}
