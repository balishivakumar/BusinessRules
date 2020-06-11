using BusinessRulesEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass
{
   public class NewMembership : IProduct,IEmail
    {
        public int ProductId { get; set; }

        public NewMembership()
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
