using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.StockManage;
using YiSha.Model.Param.StockManage;

namespace YiSha.Service.StockManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-11 14:49
    /// 描 述：库存明细服务类
    /// </summary>
    public class StockmaterService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<StockmaterEntity>> GetList(StockmaterListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<StockmaterEntity>> GetPageList(StockmaterListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<StockmaterEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<StockmaterEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(StockmaterEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                await entity.Modify();
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<StockmaterEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<StockmaterEntity, bool>> ListFilter(StockmaterListParam param)
        {
            var expression = LinqExtensions.True<StockmaterEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
