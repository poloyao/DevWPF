using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevWPF.Models;

namespace DevWPF.VM
{
    [POCOViewModel]
    public class ContractVM
    {
        bool _IsEdit = true;
        MyContract _ContractData = new MyContract();
        List<MyCreditor> _CreditorData = new List<MyCreditor>();
        List<MyWarrantee> _WarranteeData = new List<MyWarrantee>();
        List<MyCounterGuarantee> _CGList = new List<MyCounterGuarantee>();

        //public MyContract ContractData { get; set; }
        //public List<MyCreditor> CreditorData { get; set; }
        //public List<MyWarrantee> WarranteeData { get; set; }
        //public List<MyCounterGuarantee> CGList { get; set; }

        /// <summary>
        /// 设置全局是否可以编辑
        /// </summary>
        public bool IsEdit
        {
            get
            {
                return _IsEdit;
            }

            set
            {
                _IsEdit = value;
            }
        }

        public MyContract ContractData
        {
            get
            {
                return _ContractData;
            }

            set
            {
                _ContractData = value;
            }
        }

        public List<MyCreditor> CreditorData
        {
            get
            {
                return _CreditorData;
            }

            set
            {
                _CreditorData = value;
            }
        }

        public List<MyWarrantee> WarranteeData
        {
            get
            {
                return _WarranteeData;
            }

            set
            {
                _WarranteeData = value;
            }
        }

        public List<MyCounterGuarantee> CGList
        {
            get
            {
                return _CGList;
            }

            set
            {
                _CGList = value;
            }
        }

        public void Save()
        {
            _IsEdit = false;
            var sdd = MyResources.SingletonTypeCode.instance.ListTC;
        }


        
    }
}
