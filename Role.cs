using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_27
{
    public enum Role
    {
        CEO,
        [Description("sales Person")] salesPerson,
        production,
        [Description("customer Service")] customerService,
        [Description("store Keeper")] storeKeeper,
        HR,
        logistic,
        [Description("logistic Manager")] logisticManager,
        [Description("production Manager")] productionManager,
        [Description("HR Manager")] HRManager,
       
        

    }

}