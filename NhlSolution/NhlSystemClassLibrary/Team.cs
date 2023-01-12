using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
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
                _name = value.Trim(); // remove leading and trailing spaces.
            }
        }
        public Team(string Name)
        {
            this.Name = Name;
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Arena
        {
            get { return _arena; }
            set { _arena = value; }
        }

        public Conference Conference { get; set; }
        public Division Division { get; set; }
    }
}
