using NUnit.Framework;

namespace MarkEmbling.ColourLovers.Tests {
    [TestFixture]
    public class ColorRgbTests {
        [Test]
        public void Equivalent_rgb_values_are_considered_equal() {
            var rgb1 = new ColorRgb {Red = 128, Green = 128, Blue = 128};
            var rgb2 = new ColorRgb {Red = 128, Green = 128, Blue = 128};
            Assert.AreEqual(rgb1, rgb2);
        }

        [Test]
        public void Different_red_values_are_not_considered_equal() {
            var rgb1 = new ColorRgb { Red = 128, Green = 128, Blue = 128 };
            var rgb2 = new ColorRgb { Red = 255, Green = 128, Blue = 128 };
            Assert.AreNotEqual(rgb1, rgb2);
        }

        [Test]
        public void Different_green_values_are_not_considered_equal() {
            var rgb1 = new ColorRgb { Red = 128, Green = 128, Blue = 128 };
            var rgb2 = new ColorRgb { Red = 128, Green = 255, Blue = 128 };
            Assert.AreNotEqual(rgb1, rgb2);
        }

        [Test]
        public void Different_blue_values_are_not_considered_equal() {
            var rgb1 = new ColorRgb { Red = 128, Green = 128, Blue = 128 };
            var rgb2 = new ColorRgb { Red = 128, Green = 128, Blue = 255 };
            Assert.AreNotEqual(rgb1, rgb2);
        }
    }
}