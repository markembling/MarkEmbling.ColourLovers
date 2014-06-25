using System;

namespace MarkEmbling.ColourLovers {
    public class Color {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Username { get; set; }

        public int NumberOfViews { get; set; }
        public int NumberOfVotes { get; set; }
        public int NumberOfComments { get; set; }
        public int NumberOfHearts { get; set; }
        public int Rank { get; set; }

        public DateTime DateCreated { get; set; }

        public string Hex { get; set; }
        public ColorRgb Rgb { get; set; }
        public ColorHsv Hsv { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string BadgeUrl { get; set; }
        public string ApiUrl { get; set; }
    }

    public class ColorRgb {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }

    public class ColorHsv {
        public int Hue { get; set; }
        public int Saturation { get; set; }
        public int Value { get; set; }
    }
}