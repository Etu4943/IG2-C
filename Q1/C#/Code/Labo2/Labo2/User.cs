using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    internal class User
    {
        private string login;
        private int password;
        private DateTime joinDate;
        private int postCount;
        private int spacesPosted;
        private int digitsPosted;

        public User(string login, string password, DateTime joinDate)
        {
            Login = login;
            Password= password;
            this.joinDate = joinDate;
        }

        public User(string login, string password):this(login,password,DateTime.Today){}

        public void AddPost(Post post)
        {
            PostCount++;
            /*int spaceCount;
            int digitCount;
            ForumUtils.Count(post.GetContent(), out spaceCount, out digitCount);*/
            ForumUtils.CountAndUpdate(post.GetContent(), ref spacesPosted, ref digitsPosted);
            /*SpacePosted = spaceCount;
            DigitsPosted = digitCount;*/
        }

        public int SpacePosted
        {
            get { return spacesPosted; }
            set { spacesPosted += value; }
        }

        public int DigitsPosted
        {
            get { return digitsPosted; }
            set { digitsPosted += value; }
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (ForumUtils.ValidLogin(value))
                    login = value;
            }
        }

        public dynamic JoinDate
        {
            get
            {
                return joinDate.ToString("yyyyMMdd");
            }
            set
            {
                joinDate = value;
            }
        }

        public int PostCount
        {
            get
            {
                return postCount;
            }
            set
            {
                postCount = value;
            }
        }

        public dynamic Password
        {
            set
            {
                password = ForumUtils.Encode(value);
            }
        }

        public override string ToString()
        {
            return (login + " (password: " + password +"), " + JoinDate + " - " + postCount + " post" + (postCount > 1 ? "s" : ""));
        }
    }
}
