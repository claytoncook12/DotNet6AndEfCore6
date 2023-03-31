using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingNet6EFCore6.Models
{
    public class ParentGroup
    {
        public int Id { get; set; }
        public string GroupTitle { get; set; } = null!;
    }
}
