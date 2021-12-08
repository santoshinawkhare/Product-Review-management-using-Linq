using System;
using System.Collections.Generic;
using System.Data;

namespace Product_Review_management_using_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management");

            Console.WriteLine("UC1");
            List<productReview> productReviewList = new List<productReview>()
            {
                new productReview(){productId=1,userId=1,Rating=2,Review="Good",isLike=true},
                new productReview(){productId=2,userId=1,Rating=4,Review="Good",isLike=true},
                new productReview(){productId=3,userId=1,Rating=5,Review="Good",isLike=true},
                new productReview(){productId=4,userId=1,Rating=6,Review="Good",isLike=false},
                new productReview(){productId=5,userId=1,Rating=2,Review="nice",isLike=true},
                new productReview(){productId=6,userId=1,Rating=1,Review="bas",isLike=true},
                new productReview(){productId=8,userId=1,Rating=1,Review="Good",isLike=false},
                new productReview(){productId=8,userId=1,Rating=9,Review="nice",isLike=true},
                new productReview(){productId=2,userId=1,Rating=10,Review="nice",isLike=true},
                new productReview(){productId=10,userId=1,Rating=8,Review="nice",isLike=true},
                new productReview(){productId=11,userId=1,Rating=3,Review="nice",isLike=true}

            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:- " + list.productId + " " + "UserID:- " + list.userId
                 + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

            Console.WriteLine("UC2");
            Management management = new Management();
            management.TopRecords(productReviewList);

            Console.WriteLine("UC3");
            management.selectedRecord(productReviewList);

            Console.WriteLine("UC4");
            management.RetrieveCountOfRecords(productReviewList);
           /* Console.ReadKey();*/

            Console.WriteLine("UC5");
            management.RetrieveProductIDAndReviewFromList(productReviewList);

            Console.WriteLine("UC6");
            management.DisplayUnskippedRecords(productReviewList);

            Console.WriteLine("UC7");
            management.SelectProductIDAndReviews(productReviewList);

            Console.WriteLine("UC9");
            Console.WriteLine("\n*****************************DataTable Operations*************************");
            productReviewDataTable reviewDataTable = new productReviewDataTable();
            DataTable table = reviewDataTable.CreateDataBleAndAddDefaultValues();
            reviewDataTable.DisplayDataTableRecordsWithIsLikeValueTrue(table);

            Console.WriteLine("UC10");
            reviewDataTable.FindAverageRatingOfEachProductID(table);

            Console.WriteLine("UC11");
            reviewDataTable.RetrievRecordsWhoseReviewIsNice(table);

            Console.WriteLine("UC12");
            reviewDataTable.RetrievRecordsOfPerticularUserID(table);

        }
    }
}
