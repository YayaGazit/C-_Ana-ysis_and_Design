using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Group_27
{
    public enum IntactnessStatus
    {
        [Description("Still in Order Process-Not Arrived Yet")] StillinOrdeerProcessNotArrivedYet,
        [Description("All the products arrived and are in good condtion")] Alltheproductsarrivedandareingoodcondtion,
        [Description("Lack of products and some of them are defective")] Lackofproductsandsomeofthemaredefective,
        [Description("All the products arrived and some of them are defective")] Alltheproductsarrivedandsomeofthemaredefective,
        [Description("All the products are faulty")] Alltheproductsarefaulty,
        [Description("Not arrived in time")] Notarrivedintime,
        [Description("Lack of products and they are in good condition")] Lackofproductsandtheyareingoodcondition,

    }
}