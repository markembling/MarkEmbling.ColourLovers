using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace MarkEmbling.ColourLovers {
    public class ColorDeserializer {
        public IEnumerable<Color> Deserialize(Stream data) {
            
            var doc = XDocument.Load(new XmlTextReader(data));
            var results = new List<Color>();

            foreach (var element in doc.Root.Elements()) {
                if (element.Name == "color") {
                    results.Add(ColorFromElement(element));
                } else {
                    // TODO: better exceptions
                    throw new Exception("NOT A COLOR ELEMENT");
                }
            }

            return results;
        }

        private Color ColorFromElement(XElement element) {
            var color = new Color();
            color.Id = int.Parse(element.Element("id").Value);
            color.Title = element.Element("title").Value;
            return color;
        }
    }
}