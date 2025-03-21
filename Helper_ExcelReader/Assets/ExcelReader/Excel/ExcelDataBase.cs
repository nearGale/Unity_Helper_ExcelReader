using System.Linq;
using UnityEngine;

namespace ExcelDataReader
{
    public class ExcelDataBase<T> : ScriptableObject where T : ExcelItemBase
    {
        public T[] items;

        public T GetExcelItem(int targetId)
        {
            if (items != null && items.Length > 0)
            {
                return items.FirstOrDefault(item => item.id == targetId);
            }

            return null;
        }
    }

    public class ExcelItemBase
    {
        public int id;
    }
}
