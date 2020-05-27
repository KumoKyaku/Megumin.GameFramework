using System;
using System.Collections.Generic;
using System.Text;

namespace MeguminEngine.Core
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class SortAttribute : Attribute, IComparable<SortAttribute>
    {
        public SortAttribute(Type type,int index)
        {
            this.Type = type;
            this.Index = index;
        }

        public Type Type { get; }
        public int Index { get; }

        public int CompareTo(SortAttribute other)
        {
            if (Type != other?.Type)
            {
                throw new ArgumentException();
            }

            return Index.CompareTo(other.Index);
        }
    }
}
