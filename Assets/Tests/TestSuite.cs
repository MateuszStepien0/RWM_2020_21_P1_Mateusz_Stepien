using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        [SetUp]
        public void Setup()
        {

        }

        [TearDown]
        public void Teardown()
        {

        }

        [UnityTest]
        public IEnumerator UpgradeObjectCreationTest()
        {
            Upgrade testUpgrade = new Upgrade(new Pair<string, int>("Attack", 1));
            Assert.IsNotNull(testUpgrade);
            int tempUpgradeLevel = testUpgrade.GetUpgradeLevel();
            testUpgrade.IncreaseLevel();
            Assert.Greater(testUpgrade.GetUpgradeLevel(), tempUpgradeLevel);
            yield return null;
        }

        [UnityTest]
        public IEnumerator UpgradeSystemObjectCreationTest()
        {
            UpgradeSystem upgradeSystem = new UpgradeSystem();
            int listCount = upgradeSystem.getUpgradeCount();
            Assert.AreEqual(listCount, 0);
            Upgrade testUpgrade = new Upgrade(new Pair<string, int>("Attack", 1));
            upgradeSystem.AddUpgrade(testUpgrade);
            listCount = upgradeSystem.getUpgradeCount();
            Assert.AreEqual(listCount, 1);
            yield return null;
        }
    }
}
