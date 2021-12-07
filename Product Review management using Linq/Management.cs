using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product_Review_management_using_Linq
{
     public class Management
    {

        //public readonly Datatable = new Datatable();
        public void TopRecords(List<productReview> listProductReview)
        {
            var recordedData = (from productReview in listProductReview
                                orderby productReview.Rating descending
                                select productReview).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("productID:-" + list.productId + " " + "UserID:-" + list.userId +
                    " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike" + list.isLike);
            }
        }
        public void selectedRecord(List<productReview> listproductReview)
        {
            var recordData = from productReview in listproductReview
                             where (productReview.productId == 1 || productReview.productId == 4 || productReview.productId == 9)
                             && productReview.Rating > 3
                             select productReview;

        foreach (var list in recordData)
            {
                Console.WriteLine("productID:-" + list.productId + " " + "UserID:-" + list.userId +
                   " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike" + list.isLike);
            }
        }

        //UC4
        public void RetrieveCountOfRecords(List<productReview> listproductReviews)
        {
            var recordData = listproductReviews.GroupBy(x => x.productId).Select(x => new { productid = x.Key, count = x.Count()});

            foreach (var list in recordData)
            {
                Console.WriteLine(list.productid + "-----------------------------" + list.count);
            }
        }

        //UC5

        public void RetrieveProductIDAndReviewFromList(List<productReview> listproductReviews)
        {
            var recordData = listproductReviews.Select(x => new { productid = x.productId, productReview = x.Review });

            foreach (var list in recordData)
            {
                Console.WriteLine("productID:-" + list.productid + "\tproduct Review:-" + list.productReview);
            }
            Console.WriteLine("\n******************************");
        }

        //UC6


    }
}
