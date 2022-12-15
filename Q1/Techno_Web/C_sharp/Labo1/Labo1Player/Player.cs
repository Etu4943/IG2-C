using System;

namespace Labo1Player
{
    public class Player
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;
        private int skillRating;
        private bool sponsored;

        public Player(string firstName, string lastName, DateTime birthday, bool isRanked)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            skillRating = isRanked ? 1 : 0;
            this.sponsored = false;
        }
        
        public Player(string firstName,string lastName, DateTime birthday):this(firstName,lastName,birthday,true){}

        public string GetName()
        {
            return $"{this.lastName} {this.firstName}";
        }

        public string GetBirthday()
        {
            return $"{birthday.Day}/{birthday.Month}/{birthday.Year}";
        }

        public void SetRanked()
        {
            if (!IsRanked()) skillRating = 1;
        }

        public bool IsRanked()
        {
            return skillRating > 0;
        }

        public override string ToString()
        {
            return $"{GetName()}\n{GetBirthday()}\nEst competiteur : {IsRanked()}";
        }
    }
}