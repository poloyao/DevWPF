using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace DevWPF.VM
{
    [POCOViewModel]
    public class MainVM　: ViewModelBase
    {
        /// <summary>
        /// 默认初始显示的界面
        /// </summary>
        public void OnNavigateDetails()
        {
            ServiceContainer.GetService<INavigationService>().Navigate("Contract", null, this);
        }
    }
}
