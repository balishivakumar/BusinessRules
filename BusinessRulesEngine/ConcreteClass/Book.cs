using BusinessRulesEngine.Interface;

namespace BusinessRulesEngine.ConcreteClass
{
    class Book : IProduct, ICommision, IPackingSlip
    {
        public  int ProductId { get; set; }


        public Book()
        {
            PrintSlip();
            CalculateCommision();
        }


        public void CalculateCommision()
        {
            //Calculate Commision 
        }

        public void PrintSlip()
        {
            //Print Two Packaing slip
        }
    }
}
