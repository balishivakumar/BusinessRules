using BusinessRulesEngine.Interface;

namespace BusinessRulesEngine.ConcreteClass
{
   public class Video : IProduct,IFree
    {
        public  int ProductId { get; set; }

        public Video()
        {
            AddPromoItemToPackage();
        }
        public string AddPromoItemToPackage()
        {
            //Add promoItem to package if the ordered video is Learning to ski

            return "Added promo Item";
        }
    }
}
