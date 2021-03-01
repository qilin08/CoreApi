using CoreApi.Utils.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApi.MSTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void SnowIdTestMethod()
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
