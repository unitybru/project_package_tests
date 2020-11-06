using System.Collections;
using DummyPackage.Runtime;
using UnityEngine;
using UnityEngine.TestTools;

namespace DummyPackage.SampleProject
{
    public class ProjectTests1
    {
        RuntimeClass dummyobj; // this works
        
        [UnityTest]
        public IEnumerator ProjectTests_TestOne()
        {
            yield return new WaitForEndOfFrame();
        }
    }

    public class ProjectTests2
    {
        [UnityTest]
        public IEnumerator ProjectTests_TestTwo()
        {
            yield return new WaitForEndOfFrame();
        }
    }
}