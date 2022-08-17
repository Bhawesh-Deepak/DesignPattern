using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public class OnlineProduct : ProcessOrder
    {
        public override void CreateInvoice()
        {
            Console.WriteLine("Create Invoice for Online Store");
        }

        public override void CreatePackageForProduct()
        {
            Console.WriteLine("Create Package for Online Store");
        }

        public override void DecreaseProductQuantityFromInventory()
        {
            Console.WriteLine("Decrease Product Quantity for Online Store");
        }

        public override void DelivertheProduct()
        {
            Console.WriteLine("Deliver the Product to Customer Address");
        }

        public override void GetProductDetails()
        {
            Console.WriteLine("Get Product details for Online Store");
        }

        public override void PaymentForProduct()
        {
            Console.WriteLine("Get Product details for Online Store");
        }
    }
}
