using SEDC.PizzApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzApp.Models
{
    public class NewOrderViewModel : Order
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pizza { get; set; }

        public Size Size {get; set;}

    }
}
