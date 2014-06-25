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
            // ReSharper disable PossibleNullReferenceException
            var color = new Color {
                Id = int.Parse(element.Element("id").Value),
                Title = element.Element("title").Value,
                Username = element.Element("userName").Value,
                NumberOfViews = int.Parse(element.Element("numViews").Value),
                NumberOfVotes = int.Parse(element.Element("numVotes").Value),
                NumberOfComments = int.Parse(element.Element("numComments").Value),
                NumberOfHearts = int.Parse(element.Element("numHearts").Value),
                Rank = int.Parse(element.Element("rank").Value),
                DateCreated = DateTime.Parse(element.Element("dateCreated").Value),
                Hex = element.Element("hex").Value,
                Rgb = RgbFromElement(element.Element("rgb")),
                Hsv = HsvFromElement(element.Element("hsv")),
                Description = element.Element("description").Value,
                Url = element.Element("url").Value,
                ImageUrl = element.Element("imageUrl").Value,
                BadgeUrl = element.Element("badgeUrl").Value,
                ApiUrl = element.Element("apiUrl").Value
            };
            // ReSharper restore PossibleNullReferenceException
            return color;
        }

        private ColorRgb RgbFromElement(XElement element) {
            // ReSharper disable PossibleNullReferenceException
            return new ColorRgb {
                Red = int.Parse(element.Element("red").Value),
                Green = int.Parse(element.Element("green").Value),
                Blue = int.Parse(element.Element("blue").Value)
            };
            // ReSharper restore PossibleNullReferenceException
        }

        private ColorHsv HsvFromElement(XElement element) {
            // ReSharper disable PossibleNullReferenceException
            return new ColorHsv {
                Hue = int.Parse(element.Element("hue").Value),
                Saturation = int.Parse(element.Element("saturation").Value),
                Value = int.Parse(element.Element("value").Value)
            };
            // ReSharper restore PossibleNullReferenceException
        }
    }
}