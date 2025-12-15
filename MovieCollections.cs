using System;
using System.Collections.Generic;
using System.Text;
using Movie;

namespace CollectionOfMovies
{
     public class MovieCollections
     {
           private Dictionary<int,Movies> MovieCollection=new Dictionary<int,Movies>();
           public  static int movieID=0;

           
        public void AddMovie(Movies m,Message delegatem)
        {
            if (!MovieCollection.ContainsKey(++movieID))
            {
                MovieCollection.Add(movieID, m);
                delegatem("This Movie is sucessfully Added to the Dictionary",movieID);
            }
            else
            {
                throw new Exception("Movie of this ID is already in the Dictionary");
            }
        }
        public void printTheCollection()
        {
            foreach (var m in MovieCollection)
            {
                Console.WriteLine("---------------------Start------------------------------");
                Console.WriteLine($"The ID of this:{m.Key}");
                Console.WriteLine($"-This Movie is Part: {m.Value.Part}");
                Console.WriteLine($"-This Movie's Name: {m.Value.MovieName}");
                Console.WriteLine($"-This Movie's Discription: {m.Value.MovieDescription}");
                Console.WriteLine($"-The Actor of this Movie is:  {m.Value.ActorName}");
                Console.WriteLine($"-This Movie is released in: {m.Value.ReleaseData}");
                Console.WriteLine($"-The movie is a {m.Value.Language} movie");
                Console.WriteLine("-----------------------End----------------------------");
            }
        }

        public void DeleteMovie(int id)
        {
            MovieCollection.Remove(id);
        }
        public void countCollection() {
            Console.WriteLine($"The number of Movies which i have in My collection Right Now is {MovieCollection.Count}");
        }

     }
}
