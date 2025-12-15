using System;
using Movie;
using CollectionOfMovies;
public delegate void Message(String message,int i);
namespace UserSide
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Message m = (String s,int i) =>
            {
                Console.WriteLine($"{s} and the ID for your Movie is {i}");
            };
            MovieCollections cl = new MovieCollections();
            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1. Do you want to Add a Movie");
                Console.WriteLine("2. Do you want to Print the Collection My Movies");
                Console.WriteLine("3. Do you want to Remove any Movie");
                Console.WriteLine("4. Do you want the Number of Movies which are in the List");
                Console.WriteLine("5. Any Message for Us");
                Console.WriteLine("---------------------------------------------------");
                int i = Convert.ToInt32(Console.ReadLine());
               
                if (i == 1)
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Enter the the part of this Movie");
                    int j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the the Movie Name Which you want to Add In the Collection");
                    string s1 = Console.ReadLine();
                    Console.WriteLine("Enter the Discription of this Movie");
                    string s2 = Console.ReadLine();
                    Console.WriteLine("Enter the Actor of this Movie");
                    string s3 = Console.ReadLine();
                    Console.WriteLine("Enter the ReleaseDate of this Movie");
                    string s4 = Console.ReadLine();
                    Console.WriteLine("Enter the Language of this Movie");
                    string s5 = Console.ReadLine();
                    Console.WriteLine("---------------------------------------------------");
                    Movies a = new Movies() { Part = j, MovieName = s1, MovieDescription = s2, ActorName = s3, ReleaseData = s4, Language = s5 };
                    cl.AddMovie(a, m);
                }
                else if (i == 2)
                {
                    cl.printTheCollection();
                }
                else if (i == 3)
                {
                    Console.WriteLine("Enter the ID is the Movie You wants to delete");
                    int idk = Convert.ToInt32(Console.ReadLine());
                    cl.DeleteMovie(idk);
                }else if (i == 4)
                {
                    cl.countCollection();
                }
            }
           
        }
    }
}
