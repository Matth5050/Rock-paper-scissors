using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {
    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

    [TestMethod]
    public void IsWord_AWordAWord_False()
    {
      Hand testP = new Hand();
      Assert.AreEqual(false, testP.IsWord("test"));
    }

    [TestMethod]
    public void IsWord_NotAWord_True()
    {
      Hand testP = new Hand();
      Assert.AreEqual(true, testP.IsWord(" "));
    }

    [TestMethod]
    public void Decider_Rock_True()
    {
     Hand testP = new Hand();
     Assert.AreEqual(true, testP.Decider("Rock"));
     Assert.AreEqual(true, testP.Decider("Paper"));
     Assert.AreEqual(true, testP.Decider("Scissors"));
    }

    [TestMethod]
    public void Decider_Rock_False()
    {
     Hand testP = new Hand();
     Assert.AreEqual(false, testP.Decider("nothing"));
    }
  }

}