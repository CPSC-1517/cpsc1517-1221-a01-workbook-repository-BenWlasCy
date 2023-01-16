using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    public class Team
    {
        private string _name;
        private string _city;
        private string _arena;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name cannot be blank.");
                }
                // Validate new value contains only letters a-Z
                string lettersOnlyPattern = @"^[a-zA-Z ]{1,}$";
                if (!Regex.IsMatch(value, lettersOnlyPattern))
                {
                    throw new ArgumentException("Name can only contain letters.");
                }
                _name = value.Trim(); // remove leading and trailing spaces.
            }
        }
        public string City
        {
            get 
            {
                return _city;
            }
            set
            {
                //Verify that new value is not blank
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(City), "City cannot be blank.");
                }
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("City must contain 3 or more characters");
                }
                // Verify that the new value contains 3 or more characters
                _city = value.Trim();  
            }
        }
        public Team(string Name, string city, string arena, Conference conference, Division division)
        {
            this.Name = Name;
            City = city;
            Arena = arena;
            Conference = conference;
            Division = division;
        }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, Arena {Arena}, Conference: {Conference}, Division: {Division}";
        }
        public string Arena
        {
            get { return _arena; }
            set 
            {
                //Validate that the new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Arena), "Arena value cannot be blank");
                }
                _arena = value.Trim(); 
            }
        }

        public Conference Conference { get; set; }
        public Division Division { get; set; }
    }
}
