using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titles.DbContext
{
    public class TitlesObjectContextCreator : ITitlesObjectContextCreator
    {
        public ITitleDbContext Create()
        {
            var context = new TitlesObjectContext();
            context.Configure();
            return context;
        }
    }
}
