using ExcelDataReader;
using System.IO;
using UnityEngine;
 
public class ExcelReaderTest : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            ReadTransformedAsset(); // Read Generated Asset File (Recommended!)
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            TraditionalReadXlsx(); // Traditional Read Excel(.xlsx) File (Not Recommended)
        }
    }


    private void ReadTransformedAsset()
    {
        PokemonExcelData pokemonExcelData = Resources.Load<PokemonExcelData>(ExcelReaderParam.GenAssetPath_UnderResources + "/PokemonExcelData");
        if (pokemonExcelData != null)
        {
            for (int i = 0; i < pokemonExcelData.items.Length; i++)
            {
                Debug.Log(pokemonExcelData.items[i].ToString());
            }
        }
    }

    private void TraditionalReadXlsx()
    {
        using (var stream = File.Open(ExcelReaderParam.ExcelFilePath + "/Pokemon.xlsx", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
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