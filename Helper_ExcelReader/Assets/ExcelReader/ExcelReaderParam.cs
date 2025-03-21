using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExcelDataReader
{
    public static class ExcelReaderParam
    {
        /// <summary> Excel读取路径 </summary>
        public static string ExcelFilePath = Application.dataPath + "/ExcelReader/Example/Excel";

        /// <summary> 自动生成C#类文件路径 </summary>
        public static string AutoGenExcelDataCodePath =
            Application.dataPath + "/ExcelReader/Example/AutoCreateCSCode";

        /// <summary> 自动生成Asset文件路径 </summary>
        public static string ExcelAssetPath = "Assets/Resources/ExcelAsset";
    }
}
