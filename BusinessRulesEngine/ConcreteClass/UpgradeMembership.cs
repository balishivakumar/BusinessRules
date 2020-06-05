using BusinessRulesEngine.Interface;

namespace BusinessRulesEngine.ConcreteClass
{
    class UpgradeMembership : IProduct, IEmail
    {
        public int ProductId { get; set; }

        public UpgradeMembership()
        {
            Send();
        }
        public void Send()
        {
            //Call email send class
        }
    }
}
