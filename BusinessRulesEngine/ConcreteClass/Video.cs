using BusinessRulesEngine.Interface;

namespace BusinessRulesEngine.ConcreteClass
{
    class Video : IProduct,IFree
    {
        public  int ProductId { get; set; }

        public Video()
        {
            AddPromoItemToPackage();
        }
        public void AddPromoItemToPackage()
        {
            //Add promoItem to package if the ordered video is Learning to ski
        }
    }
}
