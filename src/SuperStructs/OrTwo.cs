using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct Or<T, U> : IOr
    {
        public object Content { get; private set; }

        public static implicit operator Or<T, U>(T one)
        {
            return new Or<T, U>() { Content = one };
        }

        public static implicit operator Or<T, U>(U two)
        {
            return new Or<T, U> { Content = two };
        }

        public static implicit operator T(Or<T, U> obj)
        {
            return (T)obj;
        }

        public static implicit operator U(Or<T, U> obj)
        {
            return (U)obj;
        }

        public override string ToString()
        {
            return this.Content.ToString();
        }
    }
}
