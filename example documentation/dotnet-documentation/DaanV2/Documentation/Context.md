# Context

`DaanV2.Documentation.Context`  

**contents**  
- [Summary](#summary)
- [Properties](#properties)
- [Methods](#methods)

---  
## Summary

 The class that stores the context of project   

## Properties

|Name|Description|
|---|---|
|DocumentationFiles|Gets the documentation files.|
|OutputFolder|Gets the output folder.|


---  
## Methods

### Constructor

Creates a new instance of   

### AddInputFile

 Add the given input file into the context.   

#### parameters

|Parameter|Description|
|---|---|
|Filepath|The filepath to add|

**examples**  
```csharp  
AddInputFile(Filepath)  
```  

### Load

 Loads the context from the given arguments.   

**Returns**  
The project context  

#### parameters

|Parameter|Description|
|---|---|
|args|The arguments.|

**examples**  
```csharp  
Load(args)  
```  

### SetOutputFolder

 Sets the output folder.   

#### parameters

|Parameter|Description|
|---|---|
|Filepath|The filepath to output the api to|

**examples**  
```csharp  
SetOutputFolder(Filepath)  
```  

