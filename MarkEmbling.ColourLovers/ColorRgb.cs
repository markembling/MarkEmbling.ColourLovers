namespace MarkEmbling.ColourLovers {
    public class ColorRgb {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        protected bool Equals(ColorRgb other) {
            return Red == other.Red && Green == other.Green && Blue == other.Blue;
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ColorRgb) obj);
        }

        public override int GetHashCode() {
            unchecked {
                int hashCode = Red;
                hashCode = (hashCode*397) ^ Green;
                hashCode = (hashCode*397) ^ Blue;
                return hashCode;
            }
        }
    }
}