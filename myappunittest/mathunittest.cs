using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  UnittestXamarin.viewModels;
namespace myappunittest
{
    [TestClass]
    public class mathunittest
    {
        [TestMethod]
        [TestCategory("add section")]
        public void add_4_to_6_return_10_test()
        {

            //arrange


            var vm = new MathviewModel();
            vm.VA = 4;
            vm.Vb = 6;

            //act

            vm.AddCommand.Execute(null);



            //assert
            Assert.IsTrue(vm.res==10," should be vm.res==10");


        }







        [TestMethod]
        [TestCategory("multiplycommand")]
        public void multi_4_by_6_return_24_test()
        {

            //arrange


            var vm = new MathviewModel();
            vm.VA = 4;
            vm.Vb = 6;

            //act

            vm.Multiply.Execute(null);



            //assert
           // Assert.IsTrue(vm.res == 24, " should be vm.res==24");
           Assert.AreEqual(24,vm.res, "should be vm.res==24");

            //abeterwaytodoit


        }













    }
}
