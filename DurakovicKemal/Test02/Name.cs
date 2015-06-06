using System;


namespace Test02
{
    /// <summary>
    /// Represents a first and last name
    /// </summary>
    public class Name : IEquatable<Name>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Name(string first, string last)
        {

            if (first == null || last == null)
            {
                throw new ArgumentException();
            }

            if (first == "" || last == "")
            {
                throw new ArgumentException();
            }

            First = first;
            Last = last;
            

        }

        /// <summary>
        /// First name
        /// </summary>
        public string First { get; protected set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string Last { get; protected set; }

        /// <summary>
        /// Returns the full name
        /// </summary>
        public string Full
        {
            get { return (First + Last); }
        }

        /// <summary>
        /// Create a new name with a different first name
        /// </summary>
        public Name ChangeFirst(string first)
        {
            if (first == "")
            {
                throw new ArgumentException();
            }
            if (first == null)
            {
                throw new ArgumentException();
            }
            var fullName = new Name { First = first, Last = Last };
            return fullName;
        }

        /// <summary>
        /// Create a new name with a different last name
        /// </summary>
        public Name ChangeLast(string last)
        {
            if (last == "")
            {
                throw new ArgumentException();
            }
            if (last == null)
            {
                throw new ArgumentException();
            }
            var fullName = new Name { First = First, Last = last };
            return fullName;
        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        public bool Equals(Name other)
        {
            if (other.First == First && other.Last == Last)
            {
                return true;
            }

            if (other.First != First && other.Last == Last || other.First == First && other.Last == Last)
            {
                return false;
            }

            if (other.First == null || other.Last == null)
            {
                throw new ArgumentException();
            }
            return false;
        }

        #region "Pre-built code"
        private static readonly Name none = new Name { First = string.Empty, Last = string.Empty };

        /// <summary>
        /// Constructor
        /// </summary>
        private Name()
        {

        }

        /// <summary>
        /// Represents an empty name
        /// </summary>
        /// <remarks>You should not need to touch this.  It represents an empty name</remarks>
        public static Name None
        {
            get
            {
                return none;
            }
        }

        /// <summary>
        /// Gets the hash code of the name
        /// </summary>
        /// <remarks>You should not need to touch this.  Feel free to look up what it's for</remarks>
        public override int GetHashCode()
        {
            return First.GetHashCode() ^ Last.GetHashCode();
        }

        /// <summary>
        /// Checks for equality
        /// </summary>
        /// <remarks>You should not need to touch this.  Feel free to look up what it's for</remarks>
        public override bool Equals(object obj)
        {
            return Equals(obj as Name);
        }
        #endregion
    }
}
