using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Product : IProduct
    {
        public string GetProductName()
        {
            return "Moto G5";
        }
        public string GetProductPrice()
        {
            return "2500";
        }
    }
}
