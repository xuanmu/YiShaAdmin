

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YiSha.Entity.OrganizationManage;
using YiSha.Util.Model;

    [Route("[controller]/[action]")]
    [ApiController]
    [YiSha.Admin.WebApi.Controllers.AuthorizeFilter]
    public class SaleController : ControllerBase
    {
         [HttpGet]
        public async Task<YiSha.Util.Model.TData<List<NewsEntity>>> GetPageList()
        {
           TData<List<NewsEntity>> obj = new TData<List<NewsEntity>>();
            return obj;
        }
    }