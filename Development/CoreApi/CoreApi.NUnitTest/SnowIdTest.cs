using CoreApi.Utils.Util;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreApi.NUnitTest
{
    public class SnowIdTest
    {
        [SetUp]
        public void Setup()
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

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}