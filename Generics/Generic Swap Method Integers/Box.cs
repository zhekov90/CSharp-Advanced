using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T Value => this.value;

        public override string ToString()
        {
            return $"{typeof(T)}: {this.Value}";
        }
    }
}
