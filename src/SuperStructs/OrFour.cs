using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStructs
{
    public struct Or<T, U, V, W> : IOr
    {
        public object Content { get; private set; }

        public static implicit operator Or<T, U, V, W>(T obj)
        {
            return new Or<T, U, V, W>() { Content = obj };
        }

        public static implicit operator Or<T, U, V, W>(U obj)
        {
            return new Or<T, U, V, W> { Content = obj };
        }

        public static implicit operator Or<T, U, V, W>(V obj)
        {
            return new Or<T, U, V, W> { Content = obj };
        }

        public static implicit operator Or<T, U, V, W>(W obj)
        {
            return new Or<T, U, V, W> { Content = obj };
        }

        public static implicit operator T(Or<T, U, V, W> obj)
        {
            return (T)obj;
        }

        public static implicit operator U(Or<T, U, V, W> obj)
        {
            return (U)obj;
        }

        public static implicit operator V(Or<T, U, V, W> obj)
        {
            return (V)obj;
        }

        public static implicit operator W(Or<T, U, V, W> obj)
        {
            return (W)obj;
        }

        public override string ToString()
        {
            return this.Content.ToString();
        }
    }
}
