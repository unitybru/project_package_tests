using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace DummyPackage.Tests
{
    public class PackageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [UnityTest]
        public IEnumerator PackageTests_TestOne()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}