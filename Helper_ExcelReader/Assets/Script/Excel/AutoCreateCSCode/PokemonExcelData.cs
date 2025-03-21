/*Auto Create, Don't Edit !!!*/

using UnityEngine;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using ExcelDataReader;

[Serializable]
public partial class PokemonExcelItem : ExcelItemBase
{
	public string name;
	public EPokemonAttackTendency attackTendency;
	public float basicHp;
	public float basicAttack;
	public float basicDefender;
	public List<int> otherParam;
	public List<string> stringParam;
}

[CreateAssetMenu(fileName = "PokemonExcelData", menuName = "Excel To ScriptableObject/Create PokemonExcelData", order = 1)]
public class PokemonExcelData : ExcelDataBase<PokemonExcelItem>
{
}

#if UNITY_EDITOR
public class PokemonAssetAssignment
{
	public static bool CreateAsset(List<Dictionary<string, string>> allItemValueRowList, string excelAssetPath)
	{
		if (allItemValueRowList == null || allItemValueRowList.Count == 0)
			return false;
		int rowCount = allItemValueRowList.Count;
		PokemonExcelItem[] items = new PokemonExcelItem[rowCount];
		for (int i = 0; i < items.Length; i++)
		{
			items[i] = new PokemonExcelItem();
			items[i].id = Convert.ToInt32(allItemValueRowList[i]["id"]);
			items[i].name = allItemValueRowList[i]["name"];
			items[i].attackTendency = Enum.Parse<EPokemonAttackTendency>(allItemValueRowList[i]["attackTendency"]);
			items[i].basicHp = Convert.ToSingle(allItemValueRowList[i]["basicHp"]);
			items[i].basicAttack = Convert.ToSingle(allItemValueRowList[i]["basicAttack"]);
			items[i].basicDefender = Convert.ToSingle(allItemValueRowList[i]["basicDefender"]);
			items[i].otherParam = allItemValueRowList[i]["otherParam"] == null ? new() : allItemValueRowList[i]["otherParam"].Split(';').Select(x => Convert.ToInt32(x)).ToList();
			items[i].stringParam = allItemValueRowList[i]["stringParam"] == null ? new() : allItemValueRowList[i]["stringParam"].Split(';').ToList();
		}
		PokemonExcelData excelDataAsset = ScriptableObject.CreateInstance<PokemonExcelData>();
		excelDataAsset.items = items;
		if (!Directory.Exists(excelAssetPath))
			Directory.CreateDirectory(excelAssetPath);
		string pullPath = excelAssetPath + "/" + typeof(PokemonExcelData).Name + ".asset";
		UnityEditor.AssetDatabase.DeleteAsset(pullPath);
		UnityEditor.AssetDatabase.CreateAsset(excelDataAsset, pullPath);
		UnityEditor.AssetDatabase.Refresh();
		return true;
	}
}
#endif


