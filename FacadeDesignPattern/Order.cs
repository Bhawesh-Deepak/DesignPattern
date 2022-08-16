using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Order
    {
        public void ProcessOrder()
        {
            Product prod = new Product();
            prod.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.SendInvoiceToCustomer();

            Inventory inv = new Inventory();
            inv.DecreaseProductQuantity();
        }
    }
}
