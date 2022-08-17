namespace TemplateDesignPattern
{
    public abstract class ProcessOrder
    {
        public abstract void GetProductDetails();
        public abstract void CreatePackageForProduct();

        public abstract void PaymentForProduct();

        public abstract void DelivertheProduct();

        public abstract void CreateInvoice();

        public abstract void DecreaseProductQuantityFromInventory();

        public void ProcessProductOrder()
        {
            GetProductDetails();
            CreatePackageForProduct();
            PaymentForProduct();
            DelivertheProduct();
            CreateInvoice();
            DecreaseProductQuantityFromInventory();
        }
    }
}