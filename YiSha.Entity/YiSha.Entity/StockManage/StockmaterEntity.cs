using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.StockManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-08-11 14:49
    /// 描 述：库存明细实体类
    /// </summary>
    [Table("tb_stockmater")]
    public class StockmaterEntity : BaseExtensionEntity
    {
        /// <summary>
        /// 物料编号
        /// </summary>
        /// <returns></returns>
        public string MatNo { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        /// <returns></returns>
        public string MatName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        /// <returns></returns>
        public string MatUnit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        /// <returns></returns>
        public decimal? MatPrice { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        /// <returns></returns>
        public string MatSpec { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        /// <returns></returns>
        public decimal? Amount { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public decimal? Quantity { get; set; }
        /// <summary>
        /// 库位
        /// </summary>
        /// <returns></returns>
        public string StockPos { get; set; }
    }
}
