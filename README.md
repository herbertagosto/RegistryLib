# RegistryLib

Simple library to read and edit registry


## Getting Started

```csharp
string valueName = "Value_Name_Here";
string subKeyName = "SubKey_Name_Here";

// Create SubKey in "Computer\HKEY_LOCAL_MACHINE\SOFTWARE\SubKey_Name_Here"
RegistryLib.Common regedit = new RegistryLib.Common(subKeyName);

// Create "Value_Name_Here" with DateTime.Now data
regedit.Write(valueName, DateTime.Now);

// Print "Value_Name_Here" data
Console.WriteLine("Computer\\HKEY_LOCAL_MACHINE\\SOFTWARE\\SubKey_Name_Here\\{0} = '{1}'", valueName, regedit.Read(valueName));
Console.ReadKey();

// Delete "Value_Name_Here"
regedit.DeleteKey(valueName);

// Delete "SubKey_Name_Here"
regedit.DeleteSubKeyTree();


// Create SubKey in "Computer\HKEY_CURRENT_USER\Software\SubKey_Name_Here"
RegistryLib.Common regedit_CurrentUser = new RegistryLib.Common(Registry.CurrentUser, String.Concat("Software\\", subKeyName, "\\"));
regedit_CurrentUser.Write(valueName, DateTime.Now);
Console.WriteLine("Computer\\HKEY_CURRENT_USER\\Software\\SubKey_Name_Here\\{0} = '{1}'", valueName, regedit_CurrentUser.Read(valueName));
Console.ReadKey();
regedit_CurrentUser.DeleteKey(valueName);
regedit_CurrentUser.DeleteSubKeyTree();

```

### Prerequisities

- .NET Framework 4
- Run app as Administrator


### Installing

https://www.nuget.org/packages/RegistryLib/


## Built With

visual studio 2013


## License

see [LICENSE](https://github.com/herbertagosto/RegistryLib/blob/master/LICENSE) file
