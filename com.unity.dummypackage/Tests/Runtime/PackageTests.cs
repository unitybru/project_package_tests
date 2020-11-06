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
            Debug.LogWarning($"Message from the package tests!");
        }

        [TearDown]
        public void TearDown()
        {
        }

        [UnityTest]
        public IEnumerator PackageTest()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}