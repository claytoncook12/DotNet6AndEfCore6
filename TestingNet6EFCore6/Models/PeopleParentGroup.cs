using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingNet6EFCore6.Models
{
    public class PeopleParentGroup
    {
        public int PersonId { get; set; }
        public People People { get; set; } = null!;
        public int ParentGroupId { get; set; }
        public ParentGroup ParentGroup { get; set; } = null!;
    }
}
