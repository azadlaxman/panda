using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Panda.Dal")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Data Access Layer for Panda Accountant.Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyDescription("Data Access Layer for Panda Accountant.Flavor=Release")] // a.k.a. "Comments"
#endif

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("1d693a8e-a3a2-4ea1-9f3c-ac8c847f0c1e")]
