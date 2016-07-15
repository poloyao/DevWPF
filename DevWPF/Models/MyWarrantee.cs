using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWPF.Models
{
    public class MyWarrantee
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
        public Guid? WarranteeType { get; set; }

        /// <summary>
        /// 被担保人
        /// </summary>		
        public string WarranteeName { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>		
        public Guid? CardTypeID { get; set; }

        /// <summary>
        /// 证件
        /// </summary>		
        public string CardID { get; set; }

        /// <summary>
        /// 状态位
        /// </summary>		
        public Guid? WRType { get; set; }

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
