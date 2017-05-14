using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titles.Models;

namespace Titles.Business
{
    public interface ITitleDataProvider
    {
        IEnumerable<TitleInfo> GetTitles(string titleName="");
    }
}
