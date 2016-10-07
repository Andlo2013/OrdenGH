using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Ordenes.Clases
{
    public class _toEntity
    {

        public static List<T> _table2list<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        public static T _row2object<T>(DataRow row)
        {
            if (row != null)
            {
                T item = GetItem<T>(row);
                return item;
            }
            return default(T);
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        object valor = dr[column.ColumnName]==DBNull.Value ? "" : dr[column.ColumnName];
                        pro.SetValue(obj,valor, null);
                        break;
                    }
                    ////else
                    ////    continue;
                }
            }
            return obj;
        }

    }
}
