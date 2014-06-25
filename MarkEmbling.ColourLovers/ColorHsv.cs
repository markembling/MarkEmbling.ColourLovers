namespace MarkEmbling.ColourLovers {
    public class ColorHsv {
        public int Hue { get; set; }
        public int Saturation { get; set; }
        public int Value { get; set; }

        protected bool Equals(ColorHsv other) {
            return Hue == other.Hue && Saturation == other.Saturation && Value == other.Value;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ColorHsv) obj);
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = Hue;
                hashCode = (hashCode*397) ^ Saturation;
                hashCode = (hashCode*397) ^ Value;
                return hashCode;
            }
        }
    }
}