using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachRelationshipsApplication.Models
{
    public class NovelCategory
    {
        public int NovelId { get; set; }
        public Novel Novel { get; set; }
        public int  CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
