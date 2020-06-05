using BusinessRulesEngine.ConcreteClass;
using BusinessRulesEngine.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.Factory
{
  public  class OrderFactory
    {

        public IProduct OrderCreation(string product)
        {
            IProduct InitiateProduct = null;
            switch (product)
            {
                case "Book":

                    InitiateProduct= new Book();
                    break;
                case "PhysicalProduct":

                    InitiateProduct = new PhysicalProduct();
                    break;
                case "NewMembership":

                    InitiateProduct = new NewMembership();
                    break;
                case "Upgrade":

                    InitiateProduct = new UpgradeMembership();
                    break;
                case "Video":

                    InitiateProduct = new Video();
                    break;
            }

            return InitiateProduct;
        }
    }
}
