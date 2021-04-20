using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToOops
{
    class Abstraction
    {
        public string OrderId { get; set; }
        public string OrderValue { get; set; }
        public string OrderCountry { get; set; }
        public string CreateOrder()
        {
            validateOrderValue();
            validateOrderCountry();
            return "Order created";
        }
        private bool validateOrderValue()
        {
            //implementation done here
            return true;
        }
        private bool validateOrderCountry()
        {
           
            return true;
        }
    }
}
