using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExcelDataReader
{
    /// <summary>
    /// Excel中间数据
    /// </summary>
    public class ExcelMediumData
    {
        /// <summary>
        /// Excel名字
        /// </summary>
        public string excelName;

        /// <summary>
        /// Dictionary<字段名称, 字段类型>，记录类的所有字段及其类型
        /// </summary>
        public Dictionary<string, string> propertyNameTypeDic;

        /// <summary>
        /// List<一行数据>，List<Dictionary<字段名称, 一行的每个单元格字段值>>
        /// 记录类的所有字段值，按行记录
        /// </summary>
        public List<Dictionary<string, string>> allItemValueRowList;
    }
}
