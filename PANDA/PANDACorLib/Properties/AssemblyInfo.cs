using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Panda.CorLib")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Database Core Library for Panda Accountant.Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyDescription("Database Core Library for Panda Accountant.Flavor=Release")] // a.k.a. "Comments"
#endif

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("bba18998-6a36-4def-8121-cd776a813314")]
