//
//          Copyright Seth Hendrick 2025.
// Distributed under the Boost Software License, Version 1.0.
//    (See accompanying file LICENSE_1_0.txt or copy at
//          http://www.boost.org/LICENSE_1_0.txt)
//

namespace K2SRH.Units.Tests
{
    [TestClass]
    public sealed class FrequencyTests
    {
        [TestMethod]
        public void AddTest()
        {
            Frequency f = new Frequency();
            Frequency f2 = new Frequency();

            Frequency f3 = f + f2;
        }
    }
}
