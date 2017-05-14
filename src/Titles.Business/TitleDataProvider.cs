using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titles.DbContext;
using Titles.Models;

namespace Titles.Business
{
    //Implemented ITitleDataProvider here, so that I can use DI later to inject this in controller, instead of creating the object there.
    public class TitleDataProvider : ITitleDataProvider
    {
        public IEnumerable<TitleInfo> GetTitles(string titleName="")
        {
            using (var ctx = new TitlesObjectContextCreator().Create())
            {
                List<TitleInfo> titles = null;
                if (String.IsNullOrEmpty(titleName))
                {
                    titles = ctx.Titles.Select(r => new TitleInfo() { TitleId = r.TitleId, TitleName = r.TitleName, ReleaseYear= r.ReleaseYear.Value }).ToList();
                }
                else
                {
                    titles = ctx.Titles.Where(r=> r.TitleName.Contains(titleName)).Select(t=> new TitleInfo() { TitleId = t.TitleId, TitleName = t.TitleName, ReleaseYear = t.ReleaseYear.Value }).ToList();
                }
                return titles;
            }
        }
    }
}
