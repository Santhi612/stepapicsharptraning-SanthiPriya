using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_Demo
{
    public class Abstraction
    {
        public string OrderNo { get; set; }
        public string OrderValue { get; set; }
        public string OrderCountry { get; set; }
        public string CreateOrder()
        {
            validateOrderValue();
            validateOrderCountry();

            return "order Created";
        }
        private bool validateOrderValue()
        {
            //Implementation goes here
            return true;
        }
        private bool validateOrderCountry()
        {
            return true;
        }
    }
}
