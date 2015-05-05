using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WishApp.Controllers;
using WishApp.Models;
using WishApp;


namespace WishProjectTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class ProductControllerTest
        {
            [TestMethod]
            public void TestDetailsView()
            {
                //create a controller instance
                var controller = new UsersController();
                //call the index method
                var result = controller.Index();
                //check does it return the index view
                //not working assertion needs correcting
                Assert.AreEqual("Index", result);

            }
        }
    }
}
