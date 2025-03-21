﻿using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ExcelDataReader.Editor
{
    public class BuildExcelWindow : EditorWindow
    {
        //[MenuItem("MyTools/Excel/Build Script")]
        //public static void CreateExcelCode()
        //{
        //    ExcelDataReader.ReadAllExcelToCode();
        //}

        //[MenuItem("MyTools/Excel/Build Asset")]
        //public static void CreateExcelAssset()
        //{
        //    ExcelDataReader.CreateAllExcelAsset();
        //}

        [MenuItem("MyTools/Excel Window")]
        public static void ShowExcelWindow()
        {
            //显示操作窗口方式一
            //BuildExcelWindow buildExcelWindow = GetWindow<BuildExcelWindow>();
            //buildExcelWindow.Show();
            //显示操作窗口方式二
            EditorWindow.GetWindow(typeof(BuildExcelWindow));
        }

        private string showNotify;
        private Vector2 scrollPosition = Vector2.zero;

        private List<string> fileNameList = new List<string>();
        private List<string> filePathList = new List<string>();

        private void Awake()
        {
            titleContent.text = "Excel数据读取";
        }

        private void OnEnable()
        {
            showNotify = "";
            GetExcelFile();
        }

        private void OnDisable()
        {
            showNotify = "";

            fileNameList.Clear();
            filePathList.Clear();
        }

        private void OnGUI()
        {
            scrollPosition = GUILayout.BeginScrollView(scrollPosition,
                GUILayout.Width(position.width), GUILayout.Height(position.height));

            // 自动创建C#脚本
            GUILayout.Space(10);
            GUILayout.Label("Excel To Script");
            for (int i = 0; i < fileNameList.Count; i++)
            {
                if (GUILayout.Button(fileNameList[i], GUILayout.Width(200), GUILayout.Height(30)))
                {
                    SelectExcelToCodeByIndex(i);
                }
            }

            if (GUILayout.Button("All Excel", GUILayout.Width(200), GUILayout.Height(30)))
            {
                SelectExcelToCodeByIndex(-1);
            }

            // 自动创建Asset文件
            GUILayout.Space(20);
            GUILayout.Label("Script To Asset");
            for (int i = 0; i < fileNameList.Count; i++)
            {
                if (GUILayout.Button(fileNameList[i], GUILayout.Width(200), GUILayout.Height(30)))
                {
                    SelectCodeToAssetByIndex(i);
                }
            }

            if (GUILayout.Button("All Excel", GUILayout.Width(200), GUILayout.Height(30)))
            {
                SelectCodeToAssetByIndex(-1);
            }

            //
            GUILayout.Space(20);
            GUILayout.Label(showNotify);
            //
            GUILayout.EndScrollView();
            //this.Repaint();
        }

        /// <summary>
        /// 读取指定路径下的Excel文件名
        /// </summary>
        private void GetExcelFile()
        {
            fileNameList.Clear();
            filePathList.Clear();

            if (!Directory.Exists(ExcelFileReader.excelFilePath))
            {
                showNotify = "无效路径：" + ExcelFileReader.excelFilePath;
                return;
            }

            string[] excelFileFullPaths = Directory.GetFiles(ExcelFileReader.excelFilePath, "*.xlsx");

            if (excelFileFullPaths == null || excelFileFullPaths.Length == 0)
            {
                showNotify = ExcelFileReader.excelFilePath + "路径下没有找到Excel文件";
                return;
            }

            filePathList.AddRange(excelFileFullPaths);
            for (int i = 0; i < filePathList.Count; i++)
            {
                string fileName = filePathList[i].Split('/').LastOrDefault();
                fileName = filePathList[i].Split('\\').LastOrDefault();
                fileNameList.Add(fileName);
            }

            showNotify = "找到Excel文件：" + fileNameList.Count + "个";
        }

        /// <summary>
        /// 自动创建C#脚本
        /// </summary>
        /// <param name="index"></param>
        private void SelectExcelToCodeByIndex(int index)
        {
            if (index >= 0 && index < filePathList.Count)
            {
                string fullPath = filePathList[index];
                ExcelFileReader.ReadOneExcelToCode(fullPath);
            }
            else
            {
                ExcelFileReader.ReadAllExcelToCode();
            }
        }

        /// <summary>
        /// 自动创建Asset文件
        /// </summary>
        /// <param name="index"></param>
        private void SelectCodeToAssetByIndex(int index)
        {
            if (index >= 0 && index < filePathList.Count)
            {
                string fullPath = filePathList[index];
                ExcelFileReader.CreateOneExcelAsset(fullPath);
            }
            else
            {
                ExcelFileReader.CreateAllExcelAsset();
            }
        }
    }

}
