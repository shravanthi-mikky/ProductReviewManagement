﻿using System;
using System.Collections.Generic;
using System.Data;
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
        //uc3
        public void RetriveRecords(List<ProductReview> productreviewlist)
        {
            var productData = (from productReviews in productreviewlist
                               where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                               && productReviews.Rating > 3
                               select productReviews);

            foreach (var list in productData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.Islike);
            }
        }
        //uc4
        public void CountRecords(List<ProductReview> productreviewlist)
        {
            foreach (var line in productreviewlist.GroupBy(info => info.ProductID)
                           .Select(group => new {
                               products = group.Key,
                               Count = group.Count()
                           })
                           .OrderBy(x => x.products))
            {
                Console.WriteLine("Product Id:{0} => Count :{1}", line.products, line.Count);
            }
        }
        //uc5
        public void SkipTop5Records(List<ProductReview> productreviewlist)
        {
            foreach (var productData in (from productReviews in productreviewlist
                                         select productReviews).Skip(5))
            {
                Console.WriteLine("ProductID:- " + productData.ProductID + " " + "UserID:- " + productData.UserID
                                     + " " + "Rating:- " + productData.Rating + " " + "Review:- " + productData.Review + " " + "IsLike:- " + productData.Islike);
            }
        }
        public void Datatables()
        {
            //created datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Islike");
            //created row
            dt.Rows.Add("1", "1", "Bad", "1", "False");
            dt.Rows.Add("2", "1", "BelowAverage", "2", "False");
            dt.Rows.Add("3", "1", "Average", "3", "False");
            dt.Rows.Add("4", "1", "Good", "4", "True");
            dt.Rows.Add("5", "1", "Excellent", "5", "True");
            dt.Rows.Add("6", "2", "Bad", "1", "False");
            dt.Rows.Add("7", "2", "BelowAverage", "2", "False");
            dt.Rows.Add("8", "2", "Average", "3", "False");
            dt.Rows.Add("9", "2", "Good", "4", "True");
            dt.Rows.Add("10", "2", "Excellent", "5", "True");
            dt.Rows.Add("11", "3", "Bad", "1", "False");
            dt.Rows.Add("12", "3", "BelowAverage", "2", "False");
            dt.Rows.Add("13", "3", "Average", "3", "False");
            dt.Rows.Add("14", "3", "Good", "4", "True");
            dt.Rows.Add("15", "3", "Excellent", "5", "True");
            dt.Rows.Add("16", "4", "Bad", "1", "False");
            dt.Rows.Add("17", "4", "BelowAverage", "2", "False");
            dt.Rows.Add("18", "4", "Average", "3", "False");
            dt.Rows.Add("19", "4", "Good", "4", "True");
            dt.Rows.Add("20", "4", "Excellent", "5", "True");
            dt.Rows.Add("21", "10", "Bad", "1", "False");
            dt.Rows.Add("22", "10", "BelowAverage", "2", "False");
            dt.Rows.Add("23", "10", "Average", "3", "False");
            dt.Rows.Add("24", "10", "Good", "4", "True");
            dt.Rows.Add("25", "10", "Excellent", "5", "True");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ProductId"]}\t{row["UserId"]}\t{row["Review"]}\t{row["Rating"]}\t{row["Islike"]}");
            }
        }
    }
}
