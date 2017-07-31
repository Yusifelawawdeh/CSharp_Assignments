using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfTutorials.ValueConverters
{

    /// <summary>
    /// a base converter that allows direct XAML use
    /// </summary>
    /// <typeparam name="T">the type of this value Converter</typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T: class, new()
    {

        #region Private members
        /// <summary>
        /// a single static instance of the value converter
        /// </summary>
        private static T _converter = null;

        #endregion

        #region provide value method


        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _converter ?? (_converter = new T());
        }

        #endregion

        #region value conversion methods


        /// <summary>
        /// the method to convert one type to another 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);



        /// <summary>
        /// the method to convert back the type to its source
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        #endregion
    }
}
