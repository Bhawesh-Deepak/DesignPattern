using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Invoice
    {
        public void SendInvoiceToCustomer()
        {
            Console.WriteLine("Process Payment for Product " +
                "and send invoice to customer");
        }
    }
}
