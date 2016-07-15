using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWPF.Models
{
    public class MyCounterGuaranteeItem
    {

        /// <summary>
        /// 
        /// </summary>		
        public Guid ID { get; set; }

        /// <summary>
        /// 
        /// </summary>		
        public Guid? CGID { get; set; }

        /// <summary>
        /// 反担保物名
        /// </summary>		
        public string CGIName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>		
        public string CGIType { get; set; }

        /// <summary>
        /// 价值
        /// </summary>		
        public string VGIValue { get; set; }

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
