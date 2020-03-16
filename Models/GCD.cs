using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Game.Models
{
    public class GCD
    {
        public int FirstName { get; set; }
        public int SecondName { get; set; }
        [Required(ErrorMessage = "Enter the answer")]
        public int UserAnswer { get; set; }
        public GCD()
        {

        }
        public GCD(int FirstName, int SecondName, int UserAnswer)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.UserAnswer = UserAnswer;
        }


        public int FindGcd(int firstName, int secondName)
        {
            if (firstName > secondName)
                return FindGcd(firstName - secondName, secondName);
            else if (secondName > firstName)
                return FindGcd(firstName, secondName - firstName);
            else if (firstName == secondName)
                return firstName;
            else
                return firstName;
        }
    }
}