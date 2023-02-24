using System.Data;
using System.Net.NetworkInformation;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management using LINQ");
           // UC1 - Adding a values in a list
            List<ProductReview> list = new List<ProductReview>
            {
                new ProductReview(){ProductID = 1, UserID = 1, Rating =3, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 2, UserID = 2, Rating =2, Review ="Good", isLike = false },
                new ProductReview(){ProductID = 3, UserID = 3, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 4, UserID = 4, Rating =5, Review ="nice", isLike = true },
                new ProductReview(){ProductID = 5, UserID = 5, Rating =0, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 6, UserID = 6, Rating =7, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 7, UserID = 6, Rating =10, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 8, UserID = 5, Rating =9, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 9, UserID = 7, Rating =8, Review ="nice", isLike = true },
                new ProductReview(){ProductID = 10, UserID = 3, Rating =2, Review ="Good", isLike = false },
                new ProductReview(){ProductID = 11, UserID = 2, Rating =5, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 12, UserID = 8, Rating =9, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 13, UserID = 9, Rating =1, Review ="Good", isLike = false },
                new ProductReview(){ProductID = 14, UserID = 6, Rating =8, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 15, UserID = 7, Rating =3, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 16, UserID = 4, Rating =7, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 17, UserID = 3, Rating =4, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 18, UserID = 10, Rating =2, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 19, UserID = 8, Rating =3, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 20, UserID = 1, Rating =1, Review ="Bad", isLike = false },
                new ProductReview(){ProductID = 21, UserID = 7, Rating =10, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 22, UserID = 4, Rating =7, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 23, UserID = 6, Rating =8, Review ="Good", isLike = true },
                new ProductReview(){ProductID = 24, UserID = 9, Rating =4, Review ="Average", isLike = true },
                new ProductReview(){ProductID = 25, UserID = 10, Rating =2, Review ="Bad", isLike = false },
            };

           // UC8-- > Using DataTable
            //table
            DataTable dataTable = new DataTable();
            //columns
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("isLike", typeof(bool));
            //rows
            dataTable.Rows.Add(1, 1, 3, "Bad", false);
            dataTable.Rows.Add(2, 2, 2, "Bad", false);
            dataTable.Rows.Add(3, 3, 1, "Bad", false);
            dataTable.Rows.Add(4, 4, 5, "Good", true);
            dataTable.Rows.Add(5, 5, 0, "Bad", false);
            dataTable.Rows.Add(6, 6, 7, "Good", true);
            dataTable.Rows.Add(7, 7, 10, "Best", true);
            dataTable.Rows.Add(8, 8, 9, "Best", true);
            dataTable.Rows.Add(9, 9, 8, "Best", true);
            dataTable.Rows.Add(10, 10, 2, "Bad", false);
            dataTable.Rows.Add(11, 11, 5, "Good", true);
            dataTable.Rows.Add(12, 12, 9, "Best", true);
            dataTable.Rows.Add(13, 13, 1, "Bad", false);
            dataTable.Rows.Add(14, 14, 8, "Best", true);
            dataTable.Rows.Add(15, 15, 3, "Bad", false);
            dataTable.Rows.Add(16, 16, 7, "Good", true);
            dataTable.Rows.Add(17, 17, 4, "Good", true);
            dataTable.Rows.Add(18, 18, 2, "Bad", false);
            dataTable.Rows.Add(19, 19, 3, "Bad", false);
            dataTable.Rows.Add(20, 19, 1, "Bad", false);
            dataTable.Rows.Add(21, 19, 10, "Best", true);
            dataTable.Rows.Add(22, 19, 7, "Good", true);
            dataTable.Rows.Add(23, 19, 8, "Best", true);
            dataTable.Rows.Add(24, 19, 4, "Good", true);
            dataTable.Rows.Add(25, 19, 2, "Bad", false);

            Console.WriteLine("Press 1: for Adding a Prodcut Review In list");
            Console.WriteLine("Press 2: for Retrieve top 3 records from the list");
            Console.WriteLine("Press 3: for gets products with id 1,4,9 whose rating is greater then 3");
            Console.WriteLine("Press 4: for Retrieve count of review present for each productID");
            Console.WriteLine("Press 5: for  Retrieve only productId and review from the list");
            Console.WriteLine("Press 6: for  Skips top 5 records from the list");
            Console.WriteLine("Press 7: for  Retrive Only ProductID and Review");
            Console.WriteLine("Press 8 :for read the datatable and print its rows");
            Console.WriteLine("Press 9 :for print only rows whose like is true");
            Console.WriteLine("Press 10:for Find average rating of the each productId");
            Console.WriteLine("Enter Option");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    Management.Print(list);
                    break;
                case 2:
                    Management.GetTopThree(list);
                    break;
                case 3:
                    Management.RatingAboveThree(list); 
                    break;
                case 4:
                    Management.CountByReview(list);
                    break;
                case 5:
                    Management.GetParticularFields(list);
                    break;
                case 6:
                    Management.SkipTopRecords(list);
                    break;
                case 7:
                    Management.GetParticular(list);
                    break;
                case 8:
                    Management.PrintTable(dataTable);
                    break;
                case 9:
                    Management management = new Management();
                    management.PrintTrueTable(dataTable);
                    break;
                    break;
                case 10:
                    Management.AverageRating(dataTable);
                    break;
            }
        }
    }    
}