using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPrototype
{
    public interface ICloneable<T>
    {
        public T Clone();
    }
}
