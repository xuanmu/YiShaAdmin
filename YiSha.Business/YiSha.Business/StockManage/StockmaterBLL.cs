using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.StockManage;
using YiSha.Model.Param.StockManage;
using YiSha.Service.StockManage;

namespace YiSha.Business.StockManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-11 14:49
    /// 描 述：库存明细业务类
    /// </summary>
    public class StockmaterBLL
    {
        private StockmaterService stockmaterService = new StockmaterService();

        #region 获取数据
        public async Task<TData<List<StockmaterEntity>>> GetList(StockmaterListParam param)
        {
            TData<List<StockmaterEntity>> obj = new TData<List<StockmaterEntity>>();
            obj.Result = await stockmaterService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<StockmaterEntity>>> GetPageList(StockmaterListParam param, Pagination pagination)
        {
            TData<List<StockmaterEntity>> obj = new TData<List<StockmaterEntity>>();
            obj.Result = await stockmaterService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<StockmaterEntity>> GetEntity(long id)
        {
            TData<StockmaterEntity> obj = new TData<StockmaterEntity>();
            obj.Result = await stockmaterService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(StockmaterEntity entity)
        {
            TData<string> obj = new TData<string>();
            await stockmaterService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await stockmaterService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
