using CoreApi.Utils.Util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CoreApi.XUnitTest
{
    public class SnowIdTest
    {
        [Fact]
        public void Test1()
        {
            SnowIdUtils idworker = new SnowIdUtils(1);

            Func<bool> holdBondRecordsFunc = () =>
            {
                idworker.nextId();
                return true;
            };

            List<Func<bool>> funcs = new List<Func<bool>>();

            for (int i = 0; i < 1000; i++)
            {
                funcs.Add(holdBondRecordsFunc);
            }

            Parallel.ForEach(funcs, (f) =>
            {
                f();
            });
        }
    }
}
