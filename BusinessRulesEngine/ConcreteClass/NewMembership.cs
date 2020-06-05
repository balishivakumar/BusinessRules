using BusinessRulesEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass
{
    class NewMembership : IProduct,IEmail
    {
        public int ProductId { get; set; }

        public NewMembership()
        {
            Send();
        }
        public void Send()
        {
            //Call email send class
        }
    }
}
