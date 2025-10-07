//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using Cake.Core;
using Cake.Core.IO;
using Cake.Frosting;

namespace K2SRH.Units.DevOps
{
    public class BuildContext : FrostingContext
    {
        // ---------------- Constructor ----------------

        public BuildContext( ICakeContext context ) :
            base( context )
        {
            this.RepoRoot = context.Environment.WorkingDirectory;
            this.SrcDir = this.RepoRoot.Combine( "src" );
            this.Solution = this.SrcDir.CombineWithFilePath( "K2SRH.Units.sln" );
            this.ProjectPath = this.SrcDir.CombineWithFilePath( "K2SRH.Units/K2SRH.Units.csproj" );
            this.DistFolder = this.RepoRoot.Combine( "dist" );
            this.TestResultsFolder = this.RepoRoot.Combine( "TestResults" );
            this.TestCsProj = this.SrcDir.CombineWithFilePath( "K2SRH.Units.Tests/K2SRH.Units.Tests.csproj" );
        }

        // ---------------- Properties ----------------

        public DirectoryPath RepoRoot { get; private set; }

        public DirectoryPath SrcDir { get; private set; }

        public FilePath Solution { get; private set; }

        public FilePath ProjectPath { get; private set; }

        public DirectoryPath DistFolder { get; private set; }

        public DirectoryPath TestResultsFolder { get; private set; }

        public FilePath TestCsProj { get; private set; }
    }
}