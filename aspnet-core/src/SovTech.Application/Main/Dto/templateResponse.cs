using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovTech.Main.Dto
{
    public class templateResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public ICollection<PeopleDto> results { get; set; }
    }

    public class templeteObject
    {
        public int total { get; set; }
        public ICollection<JokeDto> result { get; set; }
    }
}
