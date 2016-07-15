using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWPF.Models
{
    public class MyProject
    {
        #region 属性
        /// <summary>
        /// 获取或设置
        /// </summary>
        public Guid ID { get; set; }
        /// <summary>
        /// 获取或设置担保合同号码
        /// </summary>
        public string ContractCode { get; set; }
        /// <summary>
        /// 获取或设置担保业务编号
        /// </summary>
        public string ServiceCode { get; set; }
        /// <summary>
        /// 获取或设置
        /// </summary>
        public DateTime? UPD { get; set; }
        /// <summary>
        /// 获取或设置
        /// </summary>
        public int? Status { get; set; }
        #endregion
    }

}
