using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.StockManage;
using YiSha.Business.StockManage;
using YiSha.Model.Param.StockManage;

namespace YiSha.Admin.Web.Areas.StockManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-11 14:49
    /// 描 述：库存明细控制器类
    /// </summary>
    [Area("StockManage")]
    public class StockmaterController :  BaseController
    {
        private StockmaterBLL stockmaterBLL = new StockmaterBLL();

        #region 视图功能
        [AuthorizeFilter("stock:stockmater:view")]
        public ActionResult StockmaterIndex()
        {
            return View();
        }

        public ActionResult StockmaterForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("stock:stockmater:search")]
        public async Task<ActionResult> GetListJson(StockmaterListParam param)
        {
            TData<List<StockmaterEntity>> obj = await stockmaterBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("stock:stockmater:search")]
        public async Task<ActionResult> GetPageListJson(StockmaterListParam param, Pagination pagination)
        {
            TData<List<StockmaterEntity>> obj = await stockmaterBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<StockmaterEntity> obj = await stockmaterBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("stock:stockmater:add,stock:stockmater:edit")]
        public async Task<ActionResult> SaveFormJson(StockmaterEntity entity)
        {
            TData<string> obj = await stockmaterBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("stock:stockmater:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await stockmaterBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
