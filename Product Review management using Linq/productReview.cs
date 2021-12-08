using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_management_using_Linq
{
    public class productReview
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
