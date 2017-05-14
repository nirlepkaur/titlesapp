using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titles.DbContext
{
    public class TitlesObjectContext : TitleDbContext
    {
        public void Configure()
        {
            Database.Connection.Open();
        }
    }
}
