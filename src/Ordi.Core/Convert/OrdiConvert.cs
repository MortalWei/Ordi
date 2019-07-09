using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Ordi
{
    public static class OrdiConvert
    {
        public static List<T> ToList<T>(this DataSet ds) where T : new()
        {
            return ds.Tables[0].ToList<T>();
        }

        public static List<T> ToList<T>(this DataTable dataTable) where T : new()
        {
            List<T> list = new List<T>(dataTable.Rows.Count);
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(row.ToEntity<T>());
            }
            return list;
        }

        public static T ToEntity<T>(this DataRow row) where T : new()
        {
            var prop = ObjectProperty.GetProperties(typeof(T));
            var cols = row.Table.Columns;
            T m = new T();
            foreach (var p in prop)
            {
                if (cols.Contains(p.Info.Name))
                {
                    var val = row[p.Info.Name];
                    if ((val is DBNull) == false)
                    {
                        p.Setter(m, val);
                    }
                }
            }
            return m;
        }

        public static List<T> ToList<T>(this IDataReader reader) where T : new()
        {
            var prop = ObjectProperty.GetProperties(typeof(T));
            List<T> list = new List<T>();

            List<string> cols = new List<string>(reader.FieldCount);
            for (int i = 0; i < reader.FieldCount; i++)
            {
                cols.Add(reader.GetName(i));
            }

            while (reader.Read())
            {
                T m = new T();
                foreach (var p in prop)
                {
                    if (cols.Contains(p.Info.Name))
                    {
                        var val = reader[p.Info.Name];
                        if ((val is DBNull) == false)
                        {
                            p.Setter(m, val);
                        }
                    }
                }
                list.Add(m);
            }

            return list;
        }

        public static List<T> ConvertToModels<T>(DataSet ds) where T : new()
        {
            var prop = ObjectProperty.GetProperties(typeof(T));
            List<T> list = new List<T>(ds.Tables[0].Rows.Count);
            var cols = ds.Tables[0].Columns;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                T m = new T();
                foreach (var p in prop)
                {
                    if (cols.Contains(p.Info.Name))
                    {
                        var val = row[p.Info.Name];
                        if ((val is DBNull) == false)
                        {
                            p.Setter(m, val);
                        }
                    }
                }
                list.Add(m);
            }
            return list;
        }
    }

    /**
     * 引用: 玩转动态编译 - 高级篇：三,实例属性的读取与设置
     * https://www.cnblogs.com/blqw/p/3261240.html
     */
}
