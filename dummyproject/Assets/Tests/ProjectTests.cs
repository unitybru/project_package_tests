﻿using System.Collections;
using DummyPackage.Runtime;
using DummyPackage.Tests;
using UnityEngine;
using UnityEngine.TestTools;

namespace DummyPackage.SampleProject
{
    public class ProjectTests1
    {
        RuntimeClass dummyobj; // this works
        
        [UnityTest]
        public IEnumerator ProjectTestUsingPackageObject()
        {
            yield return new WaitForEndOfFrame();
        }
    }

    public class ProjectTests2 : PackageTests // this works as well
    {
        [UnityTest]
        public IEnumerator ProjectTestExtendingPackageTest()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}