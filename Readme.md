## Shmapper - Sharepoint Mapper
Shmapper is a lightweight mapper for Sharepoint lists (2010 and 2013).  
Maps ListItem fields to strongly typed entities and provides handy interface to work with them.  
**Wiki:** [Mapping examples](https://github.com/fixer-m/SharepointMapper/wiki/Mapping-Examples) / [Comparison with alternatives](https://github.com/fixer-m/SharepointMapper/wiki/Comparison) / [CSOM Info](https://github.com/fixer-m/SharepointMapper/wiki/CSOM-Links) 

### Main Features
- Attribute-based mapper for POCO entities
- All basic CRUD operations for collections and single entities
- Supports LINQ-filters for entities

### Fast and Simple
- Loads only mapped fields 
- LINQ queries converted to CAML (by [Camlex.Net](https://camlex.codeplex.com))
- ExecuteQuery() called few times as possible

### Basic Usage
```csharp
var SharepointClient = new SharepointClient("sharepoint-url", new NetworkCredential("user", "password"));
var CustomerByQuery = SharepointClient.Query<SpCustomer>(c => c.Title == "Cisco");

// Mapping:
[SharepointList("CustomersListName")]
public class SpCustomer : ISharepointItem
{
  [SharepointField("IdInternalName")]
  public int Id { get; set; }

  [SharepointField("TitleInternalName")]
  public string Title { get; set; }
}
```
[More Examples](https://github.com/fixer-m/SharepointMapper/wiki/Mapping-Examples) 

### Installation
There are 2 ways to use this library:
* Install-Package [Sharepoint.Shmapper](https://www.nuget.org/packages/Sharepoint.Shmapper) (via Nuget)
* Download source code and compile

### Road Map
- Check exotic fields (system, non writable, etc) 
- Support more field types
- More documentation
- Test with Sharepoint 2016
- Check mapping method (?)
- Exception handling (?)
