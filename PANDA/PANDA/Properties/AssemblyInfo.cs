using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Panda.Panda")]

// Make it easy to distinguish Debug and Release builds;
// for example, through the file properties window.
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyDescription("Panda Accoutant Web App.Flavor=Debug")] // a.k.a. "Comments"
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyDescription("Panda Accoutant Web App.Flavor=Release")] // a.k.a. "Comments"
#endif

[assembly: AssemblyCulture("")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("89555e22-d7df-4648-9b88-d209159fbf0d")]