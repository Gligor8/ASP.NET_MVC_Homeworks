using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SEDC.PizzaApp.Domain.Enums
{
    public enum DrinkSize
    {
        [Description("0.33l")]
        zeroPointThirtyThree = 1,
        [Description("0.5l")]
        zeroPointFive = 2,
        [Description("2l")]
        two = 3
      
    }
}
