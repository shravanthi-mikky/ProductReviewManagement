// See https://aka.ms/new-console-template for more information
using Product_Review;
Console.WriteLine("Welcome to Product Review Management!");
ProductReviewMethods productReviewMethods = new ProductReviewMethods();
List<ProductReview> productReviewList = new List<ProductReview>()
            {new ProductReview(){ProductID=1,UserID=1,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=2,UserID=1,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=3,UserID=1,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=4,UserID=1,Rating=4,Review="Nice",Islike=true},
            new ProductReview(){ProductID=5,UserID=1,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=6,UserID=2,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=7,UserID=2,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=8,UserID=2,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=9,UserID=2,Rating=4,Review="Nice",Islike=true},
            new ProductReview(){ProductID=10,UserID=2,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=11,UserID=3,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=12,UserID=3,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=13,UserID=3,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=14,UserID=3,Rating=4,Review="Nice",Islike=true},
            new ProductReview(){ProductID=15,UserID=3,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=16,UserID=4,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=17,UserID=4,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=18,UserID=4,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=19,UserID=4,Rating=4,Review="Nice",Islike=true},
            new ProductReview(){ProductID=20,UserID=4,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=21,UserID=10,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=22,UserID=10,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=23,UserID=10,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=24,UserID=10,Rating=4,Review="Nice",Islike=true},
            new ProductReview(){ProductID=25,UserID=10,Rating=5,Review="Excellent",Islike=true},
            };
List<ProductReview> productReviewList2 = new List<ProductReview>()
            {new ProductReview(){ProductID=1,UserID=1,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=2,UserID=1,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=2,UserID=1,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=2,UserID=1,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=3,UserID=2,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=3,UserID=2,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=3,UserID=2,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=3,UserID=2,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=4,UserID=2,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=4,UserID=3,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=4,UserID=3,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=4,UserID=3,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=4,UserID=3,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=4,UserID=3,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=5,UserID=4,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=5,UserID=4,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=5,UserID=4,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=5,UserID=4,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=5,UserID=4,Rating=5,Review="Excellent",Islike=true},
            new ProductReview(){ProductID=1,UserID=10,Rating=1,Review="Bad",Islike=false},
            new ProductReview(){ProductID=1,UserID=10,Rating=2,Review="BelowAverage",Islike=false},
            new ProductReview(){ProductID=1,UserID=10,Rating=3,Review="Average",Islike=false},
            new ProductReview(){ProductID=1,UserID=10,Rating=4,Review="Good",Islike=true},
            new ProductReview(){ProductID=1,UserID=10,Rating=5,Review="Excellent",Islike=true},
            };
while (true)
{
    Console.WriteLine("Choose the correct option : \n1Add Values to List\n2)Top 3 Records\n3)Get Records of Rating > 3 from ProductId's 1/4/9\n4)Count of ProductID and GroupBy ProductID\n5)Retieve ProductID and Review\n6)Skip Top 5 records\n7)Create a DataTable\n8)Get Records Where Islike Is True\n9)Average of Ratings by ProductId\n10)Get Records where Review = Nice\n11)Get Records Order By Rating For UserId 10\n12)Retrieve ProductId And Review using Select");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            //Display List
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID :" + list.ProductID + "  " + "UserID :" + list.UserID + "  " + "Rating :" + list.Rating + "  " + "Review :" + list.Review + "  " + "isLike :" + list.Islike);
            }
            break;
        case 2:
            productReviewMethods.Top3Records(productReviewList);
            break;
        case 3:
            productReviewMethods.RetriveRecords(productReviewList);
            break;
        case 4:
            productReviewMethods.CountRecords(productReviewList);
            break;
        case 5:
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID :" + list.ProductID + " Review :" + list.Review);
            }
            break;
        case 6:
            productReviewMethods.SkipTop5Records(productReviewList);
            break;
        case 7:
            productReviewMethods.Datatables();
            break;
        case 8:
            productReviewMethods.RecordsWhereIslikeIdTrue(productReviewList);
            break;
        case 9:
            productReviewMethods.AvgRating(productReviewList2);
            break;
        case 10:
            productReviewMethods.RecordsWhereReviewIsNice(productReviewList);
            break;
        case 11:
            productReviewMethods.OrderByRatingForUserId10(productReviewList);
            break;
        case 12:
            productReviewMethods.RetrieveProductIdAndReview(productReviewList);
            break;
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}

            
