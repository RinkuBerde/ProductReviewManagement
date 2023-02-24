using System;
using System.Collections.Generic;
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
    }
}
