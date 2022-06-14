using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool Islike { get; set; }
    }
    /*        
    *1=Bad - false
    *2=BelowAverage - false
    *3=Average - false
    *4=Good - true
    *5=Excellent - true
    */
}
