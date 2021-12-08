using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review_management_using_Linq
{
     public class productReviewDataTable
    {
        //UC8
        public DataTable CreateDataBleAndAddDefaultValues()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new[]
               {
                    new DataColumn("ProductID", typeof(int)),
                    new DataColumn("UserID", typeof(int)),
                    new DataColumn("Rating", typeof(float)),
                    new DataColumn("Review",typeof(string)),
                    new DataColumn("isLike", typeof(bool))
                }
           );
            table.Rows.Add(1, 1, 5, "Good", true);
            table.Rows.Add(2, 2, 8, "Nice", true);
            table.Rows.Add(3, 3, 4, "Good", true);
            table.Rows.Add(4, 4, 1, "Not Good", false);
            table.Rows.Add(5, 5, 5, "Good", true);
            table.Rows.Add(6, 6, 5.4, "Good", true);
            table.Rows.Add(7, 7, 8, "Nice", true);
            table.Rows.Add(8, 8, 7, "Good", true);
            table.Rows.Add(9, 9, 10, "Nice", true);
            table.Rows.Add(10, 10, 4.7, "Good", true);
            table.Rows.Add(11, 12, 5.6, "Good", true);
            table.Rows.Add(12, 13, 4, "Good", true);
            table.Rows.Add(13, 14, 2, "Not Good", false);
            table.Rows.Add(14, 15, 5, "Good", true);
            table.Rows.Add(15, 16, 2.5, "Good", true);
            table.Rows.Add(16, 17, 9, "Nice", true);
            table.Rows.Add(17, 18, 7, "Good", true);
            table.Rows.Add(18, 19, 10, "Nice", true);
            table.Rows.Add(19, 20, 5, "Good", true);
            table.Rows.Add(20, 21, 5, "Good", true);
            table.Rows.Add(21, 22, 1.3, "Not Good", false);
            table.Rows.Add(22, 23, 4, "Good", true);
            table.Rows.Add(23, 24, 2, "Not Good", false);
            table.Rows.Add(24, 24, 9, "Nice", true);
            table.Rows.Add(25, 25, 7, "Nice", true);
            return table;
        }

        //UC9
        //method to display Datatable record whose isLike value is true 
        public void DisplayDataTableRecordsWithIsLikeValueTrue(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .Where(x => x["isLike"].Equals(true));
            Console.WriteLine("\nList Of records whose isLike value is True");
            foreach (var row in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("ProductID : " + row.Field<int>("ProductID") + " " + "UserID : " + row.Field<int>("UserID") + " " + "Rating : " + row.Field<float>("Rating") + " " + "Review : " + row.Field<string>("Review") + " " + "isLike : " + row.Field<bool>("isLike") + " ");
                Console.WriteLine("\n-----------------");
            }
        }
        //UC10

        public void FindAverageRatingOfEachProductID(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                .GroupBy(x => x.Field<int>("ProductID"))
                .Select(x => new
                {
                    productID = x.Key,
                    Average = x.Average(x => x.Field<float>("Rating"))
                }).ToList();
            Console.WriteLine("\nList of average Rating for given each product ID");
            foreach (var row in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("\nProductID : " + row.productID + " " + "\nAverage Rating : " + row.Average);
                Console.WriteLine("\n-----------------");
            }
        }
        //UC11
        public void RetrievRecordsWhoseReviewIsNice(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .Where(x => x["Review"].Equals("Nice"));
            Console.WriteLine("\nList Of Products whose Review is Nice");
            foreach (var row in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("ProductID : " + row.Field<int>("ProductID") + " " + "UserID : " + row.Field<int>("UserID") + " " + "Rating : " + row.Field<float>("Rating") + " " + "Review : " + row.Field<string>("Review") + " " + "isLike : " + row.Field<bool>("isLike") + " ");
                Console.WriteLine("\n-----------------");
            }
        }

        //UC12
        public void RetrievRecordsOfPerticularUserID(DataTable table)
        {
            var records = table.Rows.Cast<DataRow>()
                          .OrderBy(x => x.Field<float>("Rating"))
                          .Where(x => x["UserID"].Equals(10));
            Console.WriteLine("\nList Of Products whose UserID is 10");
            foreach (var row in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("ProductID : " + row.Field<int>("ProductID") + " " + "UserID : " + row.Field<int>("UserID") + " " + "Rating : " + row.Field<float>("Rating") + " " + "Review : " + row.Field<string>("Review") + " " + "isLike : " + row.Field<bool>("isLike") + " ");
                Console.WriteLine("\n-----------------");
            }
        }
    }
    }

 