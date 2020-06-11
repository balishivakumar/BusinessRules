using BusinessRulesEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass
{
   public class PhysicalProduct : IProduct,ICommision,IPackingSlip
    {
        public  int ProductId { get; set; }

        public PhysicalProduct()
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
            //Print Packaing slip

            return "Printed slip";
        }
    }
}
