using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Line
    {
        public Point Start, End;

        public Line(Point Start, Point End)
        {
            this.Start = Start;
            this.End = End;
        }

        protected bool Equals(Line other)
        {
            return this.Start == other.Start && this.End == other.End;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (this.GetType() != obj.GetType()) return false;
            return Equals((Line)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Start != null ? Start.GetHashCode() : 0) * 397 ^ (End != null ? End.GetHashCode() : 0));
            }
        }
    }
}
