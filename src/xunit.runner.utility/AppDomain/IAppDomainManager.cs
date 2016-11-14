using System;
using System.Reflection;

namespace Xunit
{
    interface IAppDomainManager : IDisposable
    {
        object CreateObject(AssemblyName assemblyName, string typeName, params object[] args);
#if !PLATFORM_DOTNET
        TObject CreateObjectFrom<TObject>(string assemblyLocation, string typeName, params object[] args);
#endif
    }
}
