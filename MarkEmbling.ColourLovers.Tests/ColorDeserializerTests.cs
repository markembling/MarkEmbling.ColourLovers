using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarkEmbling.ColourLovers.Tests {
    [TestFixture]
    public class ColorDeserializerTests {
        private ColorDeserializer _deserialiser;

        [SetUp]
        public void Setup() {
            _deserialiser = new ColorDeserializer();
        }

        [Test]
        public void Deserialises_single_color_xml_into_list_of_one_color() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file);
                Assert.AreEqual(1, result.Count());
            }
        }

        [Test]
        public void Color_has_correct_id() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual(1086335, result.Id);
            }
        }

        [Test]
        public void Color_has_correct_title() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual("dutch teal", result.Title);
            }
        }

        [Test]
        public void Color_has_correct_username() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual("Skyblue2u", result.Username);
            }
        }

        [Test]
        public void Color_has_correct_numbers() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual(35873, result.NumberOfViews);
                Assert.AreEqual(833, result.NumberOfVotes);
                Assert.AreEqual(46, result.NumberOfComments);
                Assert.AreEqual(0, result.NumberOfHearts);
            }
        }

        [Test]
        public void Color_has_correct_rank() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual(4, result.Rank);
            }
        }

        [Test]
        public void Color_has_correct_date_created() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual(new DateTime(2008, 5, 19, 17, 31, 6), result.DateCreated);
            }
        }

        [Test]
        public void Color_has_correct_hex() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual("1693A5", result.Hex);
            }
        }

        [Test]
        public void Color_has_correct_rgb() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual(new ColorRgb{Red = 22, Green = 147, Blue = 165}, result.Rgb);
            }
        }

        [Test]
        public void Color_has_correct_hsv() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual(new ColorHsv { Hue = 188, Saturation = 87, Value = 65 }, result.Hsv);
            }
        }

        [Test]
        public void Color_has_correct_description() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual("", result.Description);
            }
        }

        [Test]
        public void Color_has_correct_urls() {
            using (var file = new FileStream("Data/single_color_1693A5.xml", FileMode.Open)) {
                var result = _deserialiser.Deserialize(file).First();
                Assert.AreEqual("http://www.colourlovers.com/color/1693A5/dutch_teal", result.Url);
                Assert.AreEqual("http://www.colourlovers.com/img/1693A5/100/100/dutch_teal.png", result.ImageUrl);
                Assert.AreEqual("http://www.colourlovers.com/images/badges/c/1086/1086335_dutch_teal.png", result.BadgeUrl);
                Assert.AreEqual("http://www.colourlovers.com/api/color/1693A5", result.ApiUrl);
            }
        }
    }
}
