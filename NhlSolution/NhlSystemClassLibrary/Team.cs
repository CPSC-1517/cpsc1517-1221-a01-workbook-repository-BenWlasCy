using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlSystemClassLibrary
{
    internal class Team
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Arena { get; set; }
        public Conference Conference { get; set; }
        public Division Division { get; set; }
    }
}
