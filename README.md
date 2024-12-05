# Unity_Helper_ExcelReader

## Unity Excel 读取工具

##### 依赖插件：
![image](https://github.com/user-attachments/assets/5cb63288-1887-4245-afaf-cea66c0d1ddd)




##### 表格放置位置：
![image](https://github.com/user-attachments/assets/64025d3d-71bc-4703-8177-19df795c1af6)



##### Excel 生成代码位置：
![image](https://github.com/user-attachments/assets/8f13919e-51c7-4e12-9faf-84b410c09659)



##### 生成后 Asset 位置：
![image](https://github.com/user-attachments/assets/f613359e-5527-4ac0-bdc0-2dec525cbcee)


##### 生成后 Asset:
![image](https://github.com/user-attachments/assets/ff519f1b-719c-4077-b23e-8c4cf450bdd7)




##### 测试读取代码：
![image](https://github.com/user-attachments/assets/008b5e0b-1eca-4075-9f0c-8fa1b6fccad9)



##### partical 重写 ExcelItem toString():
![image](https://github.com/user-attachments/assets/1517d9f7-9c67-4af7-85cf-9edfc292e561)



 
##### 表格内容：
 ![image](https://github.com/user-attachments/assets/21ece7b2-9847-4188-a2af-1f66be12e3ff)



##### 测试读取：
![image](https://github.com/user-attachments/assets/2ae22417-8682-4897-9aa4-623c21760805)



##### 支持枚举和数组：
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