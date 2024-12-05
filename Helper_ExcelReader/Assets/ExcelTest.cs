using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcelTest : MonoBehaviour
{
    void Start()
    {
        PokemonExcelData pokemonExcelData = Resources.Load<PokemonExcelData>("ExcelAsset/PokemonExcelData");
        if (pokemonExcelData != null)
        {
            for (int i = 0; i < pokemonExcelData.items.Length; i++)
            {
                Debug.Log(pokemonExcelData.items[i].ToString());
            }
        }
    }
}