using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWPF.Models
{
    public class MyContract
    {

        /// <summary>
        /// 
        /// </summary>		
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>		
        public Guid? Project { get; set; }
        /// <summary>
        /// 被担保人类型
        /// </summary>
        public Guid warranteeType { get; set; }
        /// <summary>
        /// 被担保人名称
        /// </summary>
        public string WarranteeName { get; set; }
        /// <summary>
        /// 被担保人证件类型
        /// </summary>
        public Guid WarranteeCodeType { get; set; }
        /// <summary>
        /// 被担保人证件
        /// </summary>
        public string WarranteeCode { get; set; }

        /// <summary>
        /// 获取或设置担保业务编号
        /// </summary>
        public string ServiceCode { get; set; }
        /// <summary>
        /// 担保业务种类
        /// </summary>		
        public Guid? BusinessTypeID { get; set; }

        /// <summary>
        /// 担保方式
        /// </summary>		
        public Guid? GuaranteeTypeID { get; set; }

        /// <summary>
        /// 担保金额
        /// </summary>		
        public string GuaranteeAmount { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>		
        public string StartDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>		
        public string EndDate { get; set; }

        /// <summary>
        /// 存出保证金比例
        /// </summary>		
        public string Deposit { get; set; }

        /// <summary>
        /// 反担保fangshi
        /// </summary>		
        public Guid? CGType { get; set; }

        /// <summary>
        /// 约定再担保补偿比例
        /// </summary>		
        public string ReGuarantee { get; set; }

        /// <summary>
        /// 费率
        /// </summary>		
        public string Ratio { get; set; }

        /// <summary>
        /// 年化
        /// </summary>		
        public string YearRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>		
        public DateTime? UPD { get; set; }

        /// <summary>
        /// 
        /// </summary>		
        public int? Status { get; set; }


    }

}
