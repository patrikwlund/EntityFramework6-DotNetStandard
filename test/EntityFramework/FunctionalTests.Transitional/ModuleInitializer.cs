// This file can be modified in any way, with two exceptions. 1) The name of
// this class must be "ModuleInitializer". 2) This class must have a public or
// internal parameterless "Run" method that returns void. In addition to these
// modifications, this file may also be moved to any location, as long as it
// remains a part of its current project.

using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace System.Data.Entity
{
    internal static class ModuleInitializer
    {
        internal static void Run()
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);

            DbProviderFactoriesCore.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactoriesCore.RegisterFactory("System.Data.SqlServerCe.3.5", SqlCeProviderFactory.Instance);
            DbProviderFactoriesCore.RegisterFactory("System.Data.SqlServerCe.4.0", SqlCeProviderFactory.Instance);
        }
    }
}