using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct Or<T, U, V> : IOr
    {
        public object Content { get; private set; }

        public static implicit operator Or<T, U, V>(T obj)
        {
            return new Or<T, U, V>() { Content = obj };
        }

        public static implicit operator Or<T, U, V>(U obj)
        {
            return new Or<T, U, V> { Content = obj };
        }

        public static implicit operator Or<T, U, V>(V obj)
        {
            return new Or<T, U, V> { Content = obj };
        }

        public static implicit operator T(Or<T, U, V> obj)
        {
            return (T)obj;
        }

        public static implicit operator U(Or<T, U, V> obj)
        {
            return (U)obj;
        }

        public static implicit operator V(Or<T, U, V> obj)
        {
            return (V)obj;
        }

        public override string ToString()
        {
            return this.Content.ToString();
        }
    }
}
