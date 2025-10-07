//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using System.Reflection;
using Cake.Frosting;
using Seth.CakeLib;

namespace K2SRH.Units.DevOps
{
    internal class Program
    {
        private static int Main( string[] args )
        {
            string exeDir = Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location ) ?? string.Empty;
            string repoRoot = Path.Combine(
                exeDir, // app
                "..", // Debug
                "..", // Bin
                "..", // DevOps csproj
                "..", // DevOps sln
                ".." // Src
            );

            return new CakeHost()
                .UseContext<BuildContext>()
                .SetToolPath( ".cake" )
                .InstallTool( new Uri( "nuget:?package=OpenCover&version=4.7.1221" ) )
                .InstallTool( new Uri( "nuget:?package=ReportGenerator&version=5.4.17" ) )
                .UseWorkingDirectory( repoRoot )
                .AddAssembly( SethCakeLib.GetAssembly() )
                .Run( args );
        }
    }
}
