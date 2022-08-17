

using TemplateDesignPattern;

namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProcessOrder processOnline = new OnlineProduct();
            processOnline.ProcessProductOrder();

            Console.WriteLine("==================Process OffLine Product==================");


            ProcessOrder processOffline = new OfflineProduct();
            processOffline.ProcessProductOrder();
        }

    }

  
}