using BusinessRulesEngine.Interface;

namespace BusinessRulesEngine.ConcreteClass
{
    public class Book : IProduct, ICommision, IPackingSlip
    {
        public  int ProductId { get; set; }


        public Book()
        {
            PrintSlip();
            CalculateCommision();
        }


        public string CalculateCommision()
        {
            //Calculate Commision 

            return "Commision calculated";
        }

        public string PrintSlip()
        {
            //Print Two Packaing slip

            return "printed 2 slips";
        }
    }
}
