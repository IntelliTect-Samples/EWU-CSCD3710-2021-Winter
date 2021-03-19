using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment9.Tests
{
    [TestClass]
    public class BooleanToVisibilityConverterTests
    {
        [TestMethod]
        public void Convert_ConvertsFalseToCollapsed()
        {
            var converter = new BooleanToVisibilityConverter();
            Visibility visibility = (Visibility)converter.Convert(false, null!, null!, null!);
            Assert.AreEqual<Visibility>(Visibility.Collapsed, visibility);
        }

        [TestMethod]

        public void Convert_ConvertsTrueToVisible()
        {
            var converter = new BooleanToVisibilityConverter();
            Visibility visibility = (Visibility)converter.Convert(true, null!, null!, null!);
            Assert.AreEqual<Visibility>(Visibility.Visible, visibility);
        }
    }
}
