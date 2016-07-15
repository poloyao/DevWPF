using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWPF.Models
{
    public class MyCreditor
    {

        /// <summary>
        /// 
        /// </summary>		
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>		
        public Guid? project { get; set; }

        /// <summary>
        /// 债权人类型
        /// </summary>		
        public Guid? CreditorTypeID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>		
        public string CreditorName { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>		
        public Guid? CardTypeID { get; set; }

        /// <summary>
        /// 证件
        /// </summary>		
        public string CardID { get; set; }

        /// <summary>
        /// 主合同编号
        /// </summary>		
        public string ContractID { get; set; }

        /// <summary>
        /// 主合同号码
        /// </summary>		
        public string ContractNumber { get; set; }

        /// <summary>
        /// 投向
        /// </summary>		
        public Guid? DirectionID { get; set; }

        /// <summary>
        /// 状态位
        /// </summary>		
        public Guid? Type { get; set; }

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
