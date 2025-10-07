//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

using Cake.ArgumentBinder;
using Cake.Frosting;
using Seth.CakeLib.TestRunner;

namespace K2SRH.Units.DevOps.Tasks
{
    public class TestArguments
    {
        // ---------------- Fields ----------------

        public static readonly string CoverageFilter = "+[K2SRH.Units]* -[K2SRH.Units.Tests]* -[K2SRH.Units.Generator]*";

        // ---------------- Constructor ----------------

        public TestArguments()
        {
            this.RunWithCodeCoverage = false;
        }

        // ---------------- Properties ----------------

        [BooleanArgument(
            "code_coverage",
            Description = "Should we run this with code coverage?",
            DefaultValue = false
        )]
        public bool RunWithCodeCoverage { get; set; }
    }

    [TaskName( "run_tests" )]
    [TaskDescription( "Runs all tests.  Pass in --code_coverage=true to run code coverage." )]
    public sealed class RunTestsTask : DevopsTask
    {
        public override void Run( BuildContext context )
        {
            var testConfig = new TestConfig
            {
                ResultsFolder = context.TestResultsFolder,
                TestCsProject = context.TestCsProj
            };

            var runner = new BaseTestRunner( context, testConfig, "K2SRH.Units.Tests" );

            TestArguments args = context.CreateFromArguments<TestArguments>();
            if( args.RunWithCodeCoverage )
            {
                runner.RunCodeCoverage( TestArguments.CoverageFilter );
            }
            else
            {
                runner.RunTests();
            }
        }
    }
}
