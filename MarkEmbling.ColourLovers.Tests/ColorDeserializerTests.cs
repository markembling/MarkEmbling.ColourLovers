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
    }
}
