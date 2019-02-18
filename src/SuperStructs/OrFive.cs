using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct Or<T, U, V, W, X> : IOr
    {
        public object Content { get; private set; }

        public static implicit operator Or<T, U, V, W, X>(T obj)
        {
            return new Or<T, U, V, W, X>() { Content = obj };
        }

        public static implicit operator Or<T, U, V, W, X>(U obj)
        {
            return new Or<T, U, V, W, X> { Content = obj };
        }

        public static implicit operator Or<T, U, V, W, X>(V obj)
        {
            return new Or<T, U, V, W, X> { Content = obj };
        }

        public static implicit operator Or<T, U, V, W, X>(W obj)
        {
            return new Or<T, U, V, W, X> { Content = obj };
        }

        public static implicit operator Or<T, U, V, W, X>(X obj)
        {
            return new Or<T, U, V, W, X> { Content = obj };
        }

        public static implicit operator T(Or<T, U, V, W, X> obj)
        {
            return (T)obj;
        }

        public static implicit operator U(Or<T, U, V, W, X> obj)
        {
            return (U)obj;
        }

        public static implicit operator V(Or<T, U, V, W, X> obj)
        {
            return (V)obj;
        }

        public static implicit operator W(Or<T, U, V, W, X> obj)
        {
            return (W)obj;
        }

        public static implicit operator X(Or<T, U, V, W, X> obj)
        {
            return (X)obj;
        }

        public override string ToString()
        {
            return this.Content.ToString();
        }
    }
}
