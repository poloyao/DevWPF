using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using DevWPF.MyResources;

namespace DevWPF.Converters
{
    /// <summary>
    /// 类型转换器
    /// </summary>
    public class TypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return SingletonTypeCode.instance.ListTC.Single(t => t.ID == (Guid)value).TypeName;
            }
            catch (Exception)
            {

                throw new Exception("TypeConverter转换类型错误");
            }         
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return SingletonTypeCode.instance.ListTC.Single(t => t.ID == (Guid)parameter).TypeValue;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
