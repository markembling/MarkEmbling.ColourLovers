using NUnit.Framework;

namespace MarkEmbling.ColourLovers.Tests {
    [TestFixture]
    public class ColorHsvTests {
        [Test]
        public void Equivalent_hsv_values_are_considered_equal() {
            var hsv1 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            var hsv2 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            Assert.AreEqual(hsv1, hsv2);
        }

        [Test]
        public void Different_hue_values_are_not_considered_equal() {
            var hsv1 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            var hsv2 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            Assert.AreNotEqual(hsv1, hsv2);
        }

        [Test]
        public void Different_saturation_values_are_not_considered_equal() {
            var hsv1 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            var hsv2 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            Assert.AreNotEqual(hsv1, hsv2);
        }

        [Test]
        public void Different_value_values_are_not_considered_equal() {
            var hsv1 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            var hsv2 = new ColorHsv { Hue = 0, Saturation = 0, Value = 0 };
            Assert.AreNotEqual(hsv1, hsv2);
        }
    }
}