//http://localhost:4459/api/Restroom/GetAllRestrooms

using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestroomLocator.WebAPI.Controllers
{
    public class RestroomController : ApiController
    {
        public List<BO.RestRoom> GetAllRestrooms()
        {
            var restroomlist = BLL.Public.FetchAllRestrooms().ToList();
            return restroomlist;
        }

        public List<BO.RestRoom> ListAllRestrooms()
        {
            var restroomlist = BLL.Public.FetchAllRestrooms().ToList();
            return restroomlist;
        }

        public bool AddRestroom(BO.RestRoom restroomObj) 
        {
          return  BLL.Admin.AddRestroomDetails(restroomObj);
        }
    }
}
