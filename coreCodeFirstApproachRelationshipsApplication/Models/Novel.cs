using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreCodeFirstApproachRelationshipsApplication.Models
{
    public class Novel
    {
        public int NovelId { get; set; }
        public string Title { get; set; }
        public List<NovelCategory> NovelCategories { get; set; }
    }
}
