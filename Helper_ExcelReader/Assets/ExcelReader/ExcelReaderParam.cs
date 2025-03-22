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
        public static string GenExcelDataCodePath = Application.dataPath + "/ExcelReader/Example/AutoCreateCSCode";

        /// <summary> 自动生成Asset文件路径，默认是在Resources下 </summary>
        public static string GenAssetPath = "Assets/Resources";

        /// <summary> 自动生成Asset文件路径（Resources之后的路径） </summary>
        public static string GenAssetPath_UnderResources = "ExcelAsset";
    }
}
