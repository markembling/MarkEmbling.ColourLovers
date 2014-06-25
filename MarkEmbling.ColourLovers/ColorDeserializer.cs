﻿using System;
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
            color.Username = element.Element("userName").Value;
            color.NumberOfViews = int.Parse(element.Element("numViews").Value);
            color.NumberOfVotes = int.Parse(element.Element("numVotes").Value);
            color.NumberOfComments = int.Parse(element.Element("numComments").Value);
            color.NumberOfHearts = int.Parse(element.Element("numHearts").Value);
            color.Rank = int.Parse(element.Element("rank").Value);
            color.DateCreated = DateTime.Parse(element.Element("dateCreated").Value);
            color.Hex = element.Element("hex").Value;
//            color.Rgb = RgbFromElement(element.Element("rgb"));
//            color.Hsv = HsvFromElement(element.Element("hsv"));
            color.Description = element.Element("description").Value;
            color.Url = element.Element("url").Value;
            color.ImageUrl = element.Element("imageUrl").Value;
            color.BadgeUrl = element.Element("badgeUrl").Value;
            color.ApiUrl = element.Element("apiUrl").Value;
            return color;
        }
    }
}