using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Panda.Services")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Business layer Contracts and services for Panda accountant.Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyDescription("Business layer Contracts and services for Panda accountant.Flavor=Release")] // a.k.a. "Comments"
#endif

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("8f45ea5b-34c7-49c7-800f-48d9a0c7fbf8")]
