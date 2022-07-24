using EqualStringsConsole;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class FindEqualTest
    {
        [Test]
        public void FindEqualHappyPathReturnProperResult()
          {
            //Arrange
            string testA = "xyz";
            string testB = "xyz";
            //Act
            var result = GenericEqual.FindEqual(testA, testB);
            //Assert
            Assert.IsTrue(result);
          }

        [Test]
        public void CheckNotEqualPathReturnProperResult()
        {
            //Arrange
            string testA = "xyz";
            string testB = "xy";
            //Act
            var result = GenericEqual.FindEqual(testA, testB);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
