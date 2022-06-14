using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review
{
    public class ProductReviewMethods
    {
        public void Top3Records(List<ProductReview> productReviewList)
        {
            var productData = (from ProductReview in productReviewList orderby ProductReview.Rating descending select ProductReview).Take(3);

            foreach (var list in productData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.Islike);
            }
        }
    }
}
