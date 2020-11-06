using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace DummyPackage.SampleProject
{
    public class ProjectTests
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
        public IEnumerator ProjectTests_TestOne()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}