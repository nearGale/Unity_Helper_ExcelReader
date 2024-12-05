using ExcelDataReader;
using System.IO;
using UnityEngine;
 
public class ExcelReader : MonoBehaviour
{
    void Start()
    {
        using (var stream = File.Open(Application.dataPath + @"/Excel/Pokemon.xlsx", FileMode.Open, FileAccess.Read))
        {
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var result = reader.AsDataSet();
                if (result.Tables.Count > 0)
                {
                    for (int i = 0; i < result.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < result.Tables[0].Columns.Count; j++)
                        {
                            Debug.Log(result.Tables[0].Rows[i][j].ToString());
                        }
                    }
                }
            }
        }
    }
}