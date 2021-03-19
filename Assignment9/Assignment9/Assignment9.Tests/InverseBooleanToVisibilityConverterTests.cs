using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class InverseBooleanToVisibilityConverterTests
    {
        [TestMethod]
        public void Convert_ConvertsTrueToCollapsed()
        {
            var converter = new InverseBooleanToVisibilityConverter();
            Visibility visibility = (Visibility)converter.Convert(true, null!, null!, null!);
            Assert.AreEqual<Visibility>(Visibility.Collapsed, visibility);
        }

        [TestMethod]
        public void Convert_ConvertsfalseToVisible()
        {
            var converter = new InverseBooleanToVisibilityConverter();
            Visibility visibility = (Visibility)converter.Convert(false, null!, null!, null!);
            Assert.AreEqual<Visibility>(Visibility.Visible, visibility);
        }
    }
}
