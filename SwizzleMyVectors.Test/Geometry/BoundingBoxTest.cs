﻿using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwizzleMyVectors.Geometry;

namespace SwizzleMyVectors.Test.Geometry
{
    [TestClass]
    public class BoundingBoxTest
    {
        readonly BoundingBox _a = new BoundingBox(new Vector3(0), new Vector3(10));
        readonly BoundingBox _b = new BoundingBox(new Vector3(5), new Vector3(15));
        readonly BoundingBox _c = new BoundingBox(new Vector3(3), new Vector3(5));
        readonly BoundingBox _d = new BoundingBox(new Vector3(100), new Vector3(110));

        [TestMethod]
        public void Intersects()
        {
            Assert.IsTrue(_a.Intersects(_b));
            Assert.IsTrue(_a.Intersects(_c));
            Assert.IsFalse(_a.Intersects(_d));
        }

        [TestMethod]
        public void Contains()
        {

            Assert.IsFalse(_a.Contains(_b) == ContainmentType.Contains);
            Assert.IsTrue(_a.Contains(_c) == ContainmentType.Contains);
            Assert.IsFalse(_a.Contains(_d) == ContainmentType.Contains);
        }
    }
}
