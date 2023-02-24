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

            Console.WriteLine("Press 1: for Adding a Prodcut Review In list");
            Console.WriteLine("Press 2: for Retrieve top 3 records from the list");
            Console.WriteLine("Press 3: for gets products with id 1,4,9 whose rating is greater then 3");
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
            }
        }
    }   
}