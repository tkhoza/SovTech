using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovTech.Main.Dto
{
    public class OutputData
    {
        public ICollection<PeopleDto> people { get; set; }

        public ICollection<string> Jokes { get; set; }
    }
}
