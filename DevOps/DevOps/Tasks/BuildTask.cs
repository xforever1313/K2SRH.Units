//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using Cake.Common.Tools.DotNet;
using Cake.Common.Tools.DotNet.Build;
using Cake.Frosting;

namespace K2SRH.Units.DevOps.Tasks
{
    [TaskName( "build" )]
    public sealed class BuildTask : DevopsTask
    {
        public override void Run( BuildContext context )
        {
            var settings = new DotNetBuildSettings
            {
            };

            context.DotNetBuild( context.Solution.ToString(), settings );
        }
    }
}
