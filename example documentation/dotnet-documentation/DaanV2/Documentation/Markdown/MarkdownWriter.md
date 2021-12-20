# MarkdownWriter

`DaanV2.Documentation.Markdown.MarkdownWriter`  

**contents**  
- [Summary](#summary)
- [Fields](#fields)
- [Methods](#methods)

---  
## Summary

Creates a markdown writer  

---  
## Fields

|Name|Description|
|---|---|
|_Writer|The writer to write to|


---  
## Methods

### Constructor

Creates a new instance of   

#### parameters

|Parameter|Description|
|---|---|
|Filepath| The filepath to the output file |
|append| If true, the file will be appended |

**examples**  
```csharp  
Boolean)(Filepath, append)  
```  

### Close

 Closes the writer   

### Finalize

 Closes the writer   

### Write

 Writes the text to the output   

#### parameters

|Parameter|Description|
|---|---|
|Text|The text to write|

**examples**  
```csharp  
Write(Text)  
```  

### WriteEndCodeBlock

 Writes a end code block to the output   

### WriteEndLine

 Writes the text to the output   

#### parameters

|Parameter|Description|
|---|---|
|Text|The text to write|

**examples**  
```csharp  
WriteEndLine(Text)  
```  

### WriteHeader

 Writer a title to the output   

#### parameters

|Parameter|Description|
|---|---|
|Header|The title to write|
|Level|The level of the title|

**examples**  
```csharp  
WriteHeader(Header, Level)  
```  

### WriteHighLighted

 Writes a seperator to the output   

#### parameters

|Parameter|Description|
|---|---|
|Text|The text to write|

**examples**  
```csharp  
WriteHighLighted(Text)  
```  

### WriteLine

 Writes the text to the output and adds a markdown ending  

#### parameters

|Parameter|Description|
|---|---|
|Text|The text to write|

**examples**  
```csharp  
WriteLine(Text)  
```  

### WriteLink

 Writes a seperator to the output   

#### parameters

|Parameter|Description|
|---|---|
|Text|The text to write|

**examples**  
```csharp  
WriteLink(Text)  
```  

### WriteSeperator

 Writes a seperator to the output   

### WriteStartCodeBlock

 Writes a start code block to the output   

### WriteStartCodeBlock

 Writes a end code block to the output   

#### parameters

|Parameter|Description|
|---|---|
|Code|The language of the code block|

**examples**  
```csharp  
WriteStartCodeBlock(Code)  
```  

### WriteTableHeader

 Writer a table title to the output   

#### parameters

|Parameter|Description|
|---|---|
|Colomns| The colomns of the table |

**examples**  
```csharp  
WriteTableHeader(Colomns)  
```  

### WriteTableRow

 Writes a table row to the output   

#### parameters

|Parameter|Description|
|---|---|
|Colomns| The colomns of the row |

**examples**  
```csharp  
WriteTableRow(Colomns)  
```  

