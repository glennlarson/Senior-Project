/*Glenn Larson
 * Cis591
 * Cycle Manager
 * Reorder Class Data Access*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senior_Project
{
    class ReOrderItem
    {
        //reorderitem attributes
        string sku_Num;
        public string SKU_Num
        {
            get { return sku_Num; }
            set { sku_Num = value; }
        }
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        double qtyOH;
        public double QtyOH
        {
            get { return qtyOH; }
            set { qtyOH = value; }
        }
        double reOrderPoint;
        public double ReOrderPoint
        {
            get { return reOrderPoint; }
            set { reOrderPoint = value; }
        }
        string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
