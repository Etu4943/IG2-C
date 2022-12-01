using Labo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //TestValidLogin();


            TestLikedBy()
;
            
        }

        static void AssertBool(string test, bool expected, bool observed)
        {
            Console.WriteLine("Test: " + test);
            Console.WriteLine("Expected: " + expected + ", observed: " + observed);
            Console.WriteLine(expected == observed ? "Ok!" : "KO !!!");
            Console.WriteLine();
        }
        static void TestValidLogin()
        {
            AssertBool("Herbert", true, ForumUtils.ValidLogin("Herbert"));
            AssertBool("empty string", false, ForumUtils.ValidLogin(""));
            AssertBool("fart", false, ForumUtils.ValidLogin("fart"));
            AssertBool("FART", false, ForumUtils.ValidLogin("FART"));
            AssertBool("FaRt", false, ForumUtils.ValidLogin("FaRt"));
        }

        static void AssertPost(string test, Post p,string likersExpected)
        {
            Console.WriteLine("Test: " + test);
            Console.WriteLine("LikedBy (Expected : ´" + likersExpected + "´) :");
            Console.WriteLine(p);
            Console.WriteLine(likersExpected == p.ToString() ? "OK !" : "KO !!!");
            Console.WriteLine();
            
            
        }

        static void AssertUser(User user, string expected, int p, int s, int d)
        {
            Console.WriteLine("Test " + expected);
            Console.WriteLine(user.PostCount + " post, " + user.SpacePosted + " space, " + user.DigitsPosted + " digit");
            Console.WriteLine((p == user.PostCount && s == user.SpacePosted && d == user.DigitsPosted) ? "OK !" : "PROBLEM !");
            Console.WriteLine();
        }

        static void TestLikedBy()
        {
            /*#region creation_users
            DateTime date1 = new DateTime(2020, 5, 13);
            DateTime date2 = new DateTime(2022, 10, 28);
            User p1 = new User("Quibble", "jvspetm23");
            User p2 = new User("Blackpopre", "titsmania", date1);
            User p3 = new User("just1", "abluto546", date2);
            #endregion
            User m = new User("Cunégonde", "motdepasse");
            Post po1 = new Post(m, "J'aime bien la chaine de Durendal");
            AssertPost("Création d'un post",po1, "");
            po1.AddLike(m);
            AssertPost("Ajout d'un liker", po1, "Cunégonde,");
            po1.AddLike(p1);
            AssertPost("Ajout d'un second liker", po1, "Cunégonde,Quibble,");
            po1.RemoveLike(m);
            AssertPost("Supression de Cunéguondre", po1, "Quibble,");
            po1.RemoveLike(p1);
            AssertPost("Supression de Quibble", po1, "");
            po1.AddLike(p1,p2,p3,m);
            AssertPost("AddLike avec un tableau", po1, "Quibble,Blackpopre,just1,Cunégonde,");*/

            User u = new User("Mélusine", "12345");
            // 0 post, 0 space, 0 digit
            AssertUser(u, "0 post, 0 space, 0 digit", 0, 0, 0);
            Post p1 = new Post(u, "Un deux trois");
            // 1 post, 2 spaces, 0 digit
            AssertUser(u, "1 post, 2 spaces, 0 digit", 1, 2, 0);
            Post p2 = new Post(u, "456");
            // 2 posts, 2 spaces, 3 digits
            AssertUser(u, "2 post, 2 spaces, 3 digit", 2, 2, 3);
            Post p3 = new Post(u, "7 8 neuf !");
            // 3 posts, 5 spaces, 5 digits
            AssertUser(u, "3 post, 5 spaces, 5 digit", 3, 5, 5);
        }


    }
}
