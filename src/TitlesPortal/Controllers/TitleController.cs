using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Titles.Business;
using Titles.Models;


namespace TitlesPortal.Controllers
{
    [RoutePrefix("api/title")]
    public class TitleController : ApiController
    {
        public IEnumerable<TitleInfo> Get()
        {
            return new TitleDataProvider().GetTitles();
            
        }
        public IEnumerable<TitleInfo> Get(string id)
        {
            return new TitleDataProvider().GetTitles(id);

        }
    }
}
