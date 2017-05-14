using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titles.Models
{
    public class TitleInfo
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public int ReleaseYear { get; set; }
        public string TitleNameSortable { get; set; }
        public DateTime ProcessedDate { get; set; }
    }
}
