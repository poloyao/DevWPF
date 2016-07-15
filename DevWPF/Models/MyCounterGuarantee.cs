using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWPF.Models
{
    public class MyCounterGuarantee
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
        /// 反担保人类型
        /// </summary>		
        public Guid? CGTypeID { get; set; }

        /// <summary>
        /// 反担保人
        /// </summary>		
        public string CGName { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>		
        public Guid? CardtypeID { get; set; }

        /// <summary>
        /// 证件
        /// </summary>		
        public string CardID { get; set; }

        /// <summary>
        /// 责任金额
        /// </summary>		
        public string ZRAmount { get; set; }

        /// <summary>
        /// zhuangtaiwei
        /// </summary>		
        public Guid? CGType { get; set; }

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
