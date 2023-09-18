using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(2, 3);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnSide1_Int()
    {
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 2);
      int result = newTriangle.Side1;
      Assert.AreEqual(length1, result);

    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Triangle newTriangle = new Triangle(3, 3);
      int newLength1 = 44;
      newTriangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnSide2_Int()
    {
      int length2 = 3;
      Triangle newTriangle = new Triangle(2, length2);
      int result = newTriangle.Side2;
      Assert.AreEqual(length2, result);
    }

  }
}