# RegistryLib

Simple library to read and edit registry


## Getting Started

```
string keyName = "TestDate";
RegistryLib.Common regedit = new RegistryLib.Common("RegistryLibDemo");
var testDate = regedit.Read(keyName);
regedit.Write(keyName, DateTime.Now);
regedit.DeleteKey(keyName);
```


### Prerequisities

.NET Framework 4


### Installing

https://www.nuget.org/packages/RegistryLib/


## Built With

visual studio 2013


## License

see [LICENSE](https://github.com/herbertagosto/RegistryLib/blob/master/LICENSE) file
