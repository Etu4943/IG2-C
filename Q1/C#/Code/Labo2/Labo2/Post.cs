using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    internal class Post
    {
        public static int INC_LIKEDBY_SIZE = 3;
        User author;
        string content;
        DateTime date;
        User[] likedBy;
        int nbLiker = 0;

        public Post(User author, string content, DateTime date)
        {
            this.author = author;
            this.content = content;
            this.date = date;
            this.likedBy = new User[INC_LIKEDBY_SIZE];
            author.AddPost(this);
        }
        public Post(User author, string content) : this(author, content, DateTime.Today) { }

        public string GetContent()
        {
            return this.content;
        } 
        public void AddLike(User user)
        {

            if((nbLiker%INC_LIKEDBY_SIZE) != 0)
            {
                likedBy[nbLiker] = user;
                nbLiker++;
            }
            else
            {
                User[] newTab = new User[nbLiker + INC_LIKEDBY_SIZE];
                likedBy.CopyTo(newTab, 0);
                likedBy = newTab;
                likedBy[nbLiker] = user;
                nbLiker++;
            }
        }

        public void AddLike(params User[] userList)
        {
            foreach (User user in userList)
            {
                AddLike(user);
            }


        }

        public void RemoveLike(User user)
        {
            int i = 0;
            while (likedBy[i].Login != user.Login && i < nbLiker-1)
            {
                i++;
            }
            if(i < nbLiker)
            {
                if(i != nbLiker-1)
                {
                    for (int j = i; j < nbLiker; j++)
                    {
                        likedBy[j] = likedBy[j + 1];
                    }
                }
                nbLiker--;
                
            }
        }

        public override string ToString()
        {
            string output = "";
            int i = 0;
            while (likedBy[i]!=null)
            {
                output += likedBy[i].Login + ",";
                i++;
            }
            return output;
        }

    }
}
