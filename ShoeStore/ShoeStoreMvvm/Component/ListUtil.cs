using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pers.Fhr.ShoeStoreLib.Component
{
    /// <summary>
    /// ListHelper
    /// 2017/1/21  fhr
    /// 可以考虑使用静态方法扩展
    /// </summary>
    public static class ListUtil
    {
        /// <summary>
        /// 将泛类型集合List类转换成DataTable
        /// </summary>
        /// <param name="list">泛类型集合</param>
        /// <returns></returns>
        public static DataTable ListToDataTable<T>(this List<T> entitys)
        {
            //检查实体集合不能为空
            if (entitys == null)
            {
                throw new Exception("需转换的集合为空");
            }
            Type entityType;
            PropertyInfo[] entityProperties;
            InitialPropertyAndType<T>(entitys, out entityType, out entityProperties);
            DataTable dt = InitialDataTable(entityProperties);
            FillDataTable<T>(entitys, entityType, entityProperties, dt);
            return dt;
        }

        private static void FillDataTable<T>(List<T> entitys, Type entityType, PropertyInfo[] entityProperties, DataTable dt)
        {
            //将所有entity添加到DataTable中
            entitys.ForEach(entity =>
            {
                //检查所有的的实体都为同一类型
                if (entity.GetType() != entityType)
                {
                    throw new Exception("要转换的集合元素类型不一致");
                }
                object[] entityValues = new object[entityProperties.Length];
                for (int i = 0; i < entityProperties.Length; i++)
                {
                    entityValues[i] = entityProperties[i].GetValue(entity, null);
                }
                dt.Rows.Add(entityValues);
            });
        }

        private static DataTable InitialDataTable(PropertyInfo[] entityProperties)
        {
            //生成DataTable的structure
            //生产代码中，应将生成的DataTable结构Cache起来，此处略
            DataTable dt = new DataTable();
            for (int i = 0; i < entityProperties.Length; i++)
            {
                dt.Columns.Add(entityProperties[i].Name);
            }
            return dt;
        }

        private static void InitialPropertyAndType<T>(List<T> entitys, out Type entityType, out PropertyInfo[] entityProperties)
        {
            //取出第一个实体的所有Propertie
            entityType = entitys[0].GetType();
            entityProperties = entityType.GetProperties();
        }
    }
}
