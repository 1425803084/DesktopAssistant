using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAssistant.bases.utils
{
    class ModelUtils
    {
        /// <summary>
        ///   将SqlDataReader转换为Model实体
        /// </summary>
        /// <typeparam name="T">实例类名</typeparam>
        /// <param name="dr">Reader对象</param>
        /// <returns>实体对象</returns>
        public static T ReaderToModel<T>(IDataReader dr)
        {
            try
            {
                using (dr)
                {
                    if (dr.Read())
                    {
                        Type modelType = typeof(T);
                        T model = Activator.CreateInstance<T>();
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            if (!IsNullOrDbNull(dr[i]))
                            {
                                PropertyInfo pi = modelType.GetProperty(GetPropertyName(dr.GetName(i)));
                                pi.SetValue(model, HackType(dr[i], pi.PropertyType), null);
                            }
                        }
                        return model;
                    }
                }
                return default(T);
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        ///   将SqlDataReader转换为Model实体
        /// </summary>
        /// <typeparam name="T">实例类名</typeparam>
        /// <param name="dr">Reader对象</param>
        /// <returns>实体对象</returns>
        public static List<T> ReaderToModelList<T>(IDataReader dr)
        {
            try
            {
                using (dr)
                {
                    List<T> models = new List<T>();
                    while (dr.Read())
                    {
                        Type modelType = typeof(T);
                        T model = Activator.CreateInstance<T>();
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            if (!IsNullOrDbNull(dr[i]))
                            {
                                PropertyInfo pi = modelType.GetProperty(GetPropertyName(dr.GetName(i)));
                                pi.SetValue(model, HackType(dr[i], pi.PropertyType), null);
                            }
                        }
                        models.Add(model);
                    }
                    return models;
                }
                return default(List<T>);
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        ///  对可空类型进行判断.
        /// </summary> 
        private static object HackType(object value, Type conversionType) { 

        if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
        {
            if (value == null)
            {
                return null;
            }
            System.ComponentModel.NullableConverter nullAbleConverter = new System.ComponentModel.NullableConverter(conversionType);
            conversionType = nullAbleConverter.UnderlyingType;
        }
        return Convert.ChangeType(value, conversionType);
    }

    /// <summary>
    ///  判断字段值是否为NUll
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    private static bool IsNullOrDbNull(object obj)
    {
        return ((obj is DBNull) || string.IsNullOrEmpty(obj.ToString())) ? true : false;
    }

    /// <summary>
    ///  获取属性类的名称
    /// </summary>
    /// <param name="column">列名</param>
    /// <returns>列名</returns>
    private static string GetPropertyName(string column)
    {
        string[] narr = column.Split('_');
        column = "";
        for (int i = 0; i < narr.Length; i++)
        {
            if (narr[i].Length > 1)
            {
                column += narr[i].Substring(0, 1).ToUpper() + narr[i].Substring(1);
            }
            else
            {
                column += narr[i].Substring(0, 1).ToUpper();
            }
        }
        return column;
    }
    }
}
