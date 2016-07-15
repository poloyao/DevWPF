using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevWPF.Models;

namespace DevWPF.MyResources
{
    public class SingletonTypeCode
    {
        //private volatile static SingletonTypeCode _instance = null;

        //private static readonly object lockHelper = new object();

        //private SingletonTypeCode() { }

        //public static SingletonTypeCode CreateInstance()
        //{
        //    if (_instance == null)
        //    {
        //        lock (lockHelper)
        //        {
        //            if (_instance == null)
        //                _instance = new SingletonTypeCode();
        //        }
        //    }
        //    return _instance;
        //}


        private SingletonTypeCode() {
            //获取类型数据
        }

        public static readonly SingletonTypeCode instance = new SingletonTypeCode();

        List<Models.MyTypeCode> _ListTC = new List<Models.MyTypeCode>();
        

        public List<MyTypeCode> ListTC
        {
            get
            {
                return _ListTC;
            }

            set
            {
                _ListTC = value;
            }
        }
        


    }
}
