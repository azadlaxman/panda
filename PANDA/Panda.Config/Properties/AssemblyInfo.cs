using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Panda.Config")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Configuration Classes for Panda Accountant.Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyDescription("Configuration Classes for Panda Accountant.Flavor=Release")] // a.k.a. "Comments"
#endif
// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b6eb393d-1f2c-43d4-8802-096b19adf230")]