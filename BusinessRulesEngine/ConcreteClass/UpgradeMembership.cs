using BusinessRulesEngine.Interface;

namespace BusinessRulesEngine.ConcreteClass
{
   public class UpgradeMembership : IProduct, IEmail
    {
        public int ProductId { get; set; }

        public UpgradeMembership()
        {
            Send();
        }
        public string Send()
        {
            //Call email send class
            return "Mail Sent";
        }
    }
}
