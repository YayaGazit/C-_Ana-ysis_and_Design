using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_27
{
    public enum OrderStatus
    {
        [Description("waiting For Products")] waitingForProducts,
        [Description("in Production Process")] inProductionProcess,
        packeging,
        [Description("in Delivery")] inDelivery,
        assembling,
        inQA,
        orderAnalayze,
        inInventory,
        done
    }
}