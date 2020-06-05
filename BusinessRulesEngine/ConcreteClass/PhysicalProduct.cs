using BusinessRulesEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.ConcreteClass
{
    class PhysicalProduct : IProduct,ICommision,IPackingSlip
    {
        public  int ProductId { get; set; }

        public PhysicalProduct()
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
            //Print Packaing slip
        }
    }
}
