using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct Or<T> : IOr
    {
        public object Content { get; private set; }

        public static implicit operator Or<T>(T one)
        {
            return new Or<T>() { Content = one };
        }


        public static implicit operator T(Or<T> obj)
        {
            return (T)obj;
        }

        public override string ToString()
        {
            return this.Content.ToString();
        }
    }
}
