using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Management
    {
        //UC-01----> prints the product review
        public static void Print(IEnumerable<ProductReview> productReviews)
        {
            foreach (var item in productReviews)
            {
                Console.WriteLine($"Product ID: {item.ProductID}, User ID: {item.UserID}, Rating: {item.Rating}, Review: {item.Review}, Like: {item.isLike}");
            }
        }
        //UC-02----->  Retrieve top 3 records from the list who’s rating is high
        public static  void GetTopThree(List<ProductReview> productReviews)
        {
            var query = (from products in productReviews
                         orderby products.Rating descending
                         select products).Take(3);

            Print(query);
        }
        //UC-03----> gets products with id 1,4,9 whose rating is greater then 3
        public static  void RatingAboveThree(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        where (products.ProductID == 1 || products.ProductID == 4 || products.ProductID == 9) && products.Rating >= 3
                        select products;
            Print(query);
        }
        // UC-04----> groups the products by reviews
        public static void CountByReview(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        group products by products.Review;

            foreach (var item in query)
            {
                Console.WriteLine($"Review : {item.Key}");
                foreach (ProductReview items in item)
                {
                    Console.WriteLine($"Product ID: {items.ProductID}, User ID: {items.UserID}, Rating: {items.Rating}, Review: {items.Review}, Like: {items.isLike}");

                }
            }
        }
        // UC-05----> Retrieve only productId and review from the list
        public static void GetParticularFields(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        select (products.ProductID, products.Review);

            foreach (var item in query)
            {
                Console.WriteLine($"Product ID: {item.ProductID} Review: {item.Review}");
            }
        }
        // UC-06----> Skips top 5 records from the list
        public static void SkipTopRecords(List<ProductReview> productReviews)
        {
            var query = (from products in productReviews
                         orderby products.Rating descending
                         select products).Skip(5);

            Print(query);
        }
        // UC-07-------> Retrive Only ProductID and Review
        public static void GetParticular(List<ProductReview> productReviews)
        {
            var query = from products in productReviews
                        select (products.ProductID, products.Review);

            foreach (var item in query)
            {
                Console.WriteLine($"Product ID: {item.ProductID} Review: {item.Review}");
            }
        }

        // UC-08-------> Using DataTable 
        public static void PrintTable(DataTable dataTable)
        {
            var Products = from products in dataTable.AsEnumerable()
                           select (products.Field<int>("ProductID"), products.Field<int>("UserID"), products.Field<int>("Rating"),
                           products.Field<string>("Review"), products.Field<bool>("isLike"));
            Console.WriteLine("ProductID  UserID  Rating  Review  Like");
            foreach (var item in Products)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3 + " " + item.Item4 + " " + item.Item5);
            }
        }
        // printing datatable after linq operations
        public void PrintDataTable(EnumerableRowCollection<(int, int, int, string, bool)> products)
        {
            Console.WriteLine("ProductID  UserID  Rating  Review  Like");
            foreach (var item in products)
            {
                Console.WriteLine(item.Item1 + " " + item.Item2 + " " + item.Item3 + " " + item.Item4 + " " + item.Item5);
            }
        } 
        
        //UC-09------> method to print rows whose isLike is true
        public  void PrintTrueTable(DataTable dataTable)
        {
            var products = from product in dataTable.AsEnumerable()
                           where (product.Field<bool>("isLike") == true)
                           select (product.Field<int>("ProductID"), product.Field<int>("UserID"), product.Field<int>("Rating"),
                           product.Field<string>("Review"), product.Field<bool>("isLike"));
            PrintDataTable(products);
        }
        //UC-10------> Find average rating of the each productId
        public static void AverageRating(DataTable dataTable)
        {
            var average = (from product in dataTable.AsEnumerable()
                           select (product.Field<int>("Rating"))).Average();
            Console.WriteLine(average.ToString());
        }
        //UC-11------> Retreive all records from the list who’s review message contain “Best”
        public void ReviewIsBest(DataTable dataTable)
        {
            var products = from product in dataTable.AsEnumerable()
                           where (product.Field<string>("Review").Contains("Best"))
                           select (product.Field<int>("ProductID"), product.Field<int>("UserID"), product.Field<int>("Rating"),
                           product.Field<string>("Review"), product.Field<bool>("isLike"));
            PrintDataTable(products);
        }
    }
}
