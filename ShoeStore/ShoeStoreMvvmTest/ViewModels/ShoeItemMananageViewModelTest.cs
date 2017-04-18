using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoeStoreMvvm.ViewModels;

namespace ShoeStoreMvvmTest.ViewModels
{
    [TestClass]
    public class ShoeItemMananageViewModelTest
    {
        private ShoeItemMananageViewModel shoeItemMananageViewModel = new ShoeItemMananageViewModel();
        [TestMethod]
        public void TestLoadCommand()
        {
            shoeItemMananageViewModel.LoadCommand.Execute(null);
            Assert.IsNotNull(shoeItemMananageViewModel.ShoeItems);
        }
    }
}
