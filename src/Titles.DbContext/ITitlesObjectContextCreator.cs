using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titles.DbContext
{
    public interface ITitlesObjectContextCreator
    {
        ITitleDbContext Create();
    }
}
