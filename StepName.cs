using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_27
{
    public enum StepName
    {
     
        [Description("Product Collection")] productCollection,
        SMT,
        AOI,
        [Description("Through Hole")] throughHole,
        QA,
        packeging


    }
}
