# Unity_Helper_ExcelReader

## Unity Excel 读取工具

对于Excel配置文件，生成对应的读取代码、转换为Asset文件。

支持枚举和数组类型。

已屏蔽excel打开时的临时文件（~$xxx.xlsx）

#### 工程结构：
![image](https://github.com/user-attachments/assets/c34ac7d2-966f-4578-8309-94f55247d9f1)

![image](https://github.com/user-attachments/assets/b0e50fbd-7117-4350-8682-5de0b217c367)


#### 编辑器工具：
![image](https://github.com/user-attachments/assets/74845cf6-807e-4351-a5a6-91a01bafef40)
![image](https://github.com/user-attachments/assets/6c62ac1b-a963-4b14-85ed-7e05ed7b124f)




#### 配置、生成读取代码、生成配置asset，默认位置
![image](https://github.com/user-attachments/assets/a44968ae-c23d-4f60-bdaa-ee3f7a608554)


#### 表格放置位置：
![image](https://github.com/user-attachments/assets/51244cc3-473e-408d-9b8f-61831f9f5086)



#### Excel 生成代码位置：
![image](https://github.com/user-attachments/assets/034a1213-cbe6-45e0-bdbb-1f16a30adcd5)



#### 生成后 Asset 位置：
![image](https://github.com/user-attachments/assets/3e7792f9-cfe3-4ba8-bb2d-22feeef45779)


#### 生成后 Asset:
![image](https://github.com/user-attachments/assets/ff519f1b-719c-4077-b23e-8c4cf450bdd7)




#### 测试读取代码：
![image](https://github.com/user-attachments/assets/55a43bc5-ed69-42fa-869f-65eacfaf0349)




#### partical 重写 ExcelItem toString():
![image](https://github.com/user-attachments/assets/487cabf5-adf4-4359-b0ef-70863cf6e524)



 
#### 表格内容：
 ![image](https://github.com/user-attachments/assets/21ece7b2-9847-4188-a2af-1f66be12e3ff)



#### 测试读取：
![image](https://github.com/user-attachments/assets/2ae22417-8682-4897-9aa4-623c21760805)



#### 支持枚举和数组：
![image](https://github.com/user-attachments/assets/9e5f0706-16e2-4174-b8b9-5c72817aafcc)




## 插件 IExcelDataReader 的属性和方法：

##### Read()：从当前工作表中读取一行数据
##### NextResult()：移到下一个工作表
##### ResultsCount：返回Excel文件中工作表中的数量
##### Name：返回当前工作表的名称
##### FieldCount：返回当前表中的列数
##### RowCount：返回当前表中的行数。这包括由 AsDataSet （） 排除的终端空行
##### HeaderFooter：返回带有有关页眉和页脚信息的对象，如果没有，则返回null
##### MergeCells：返回当前表中的合并单元格范围数组
##### RowHeight：返回当前行的可视高度(以点为单位)。如果该行被隐藏，则可能为0
##### GetColumnWidth()：以字符单位返回列的宽度。如果该列被隐藏，则可能为0
##### GetFieldType()：返回当前行的值的类型。总是Excel支持的类型之一:double、int、bool、DateTime、TimeSpan、string，如果没有值，则为null
##### IsDBNull()：检查当前行中的值是否为空
##### GetValue()：从当前行返回一个值作为对象，如果没有值则返回null
##### GetDouble()：将当前行的值转换为它们各自的类型并返回，其他：GetInt32()、GetBoolean()、GetDateTime()、GetString()
##### GetNumberFormatString()：返回包含当前行的值的格式化代码的字符串，如果没有值则返回null
##### GetNumberFormatIndex()：返回当前行的值的数字格式索引。164以下的索引值表示内置的数字格式，否则表示自定义数字格式。
##### GetCellStyle()：返回包含当前行中单元格的样式信息的对象
#####       除非类型完全匹配，否则Get()方法将抛出InvalidCastException
