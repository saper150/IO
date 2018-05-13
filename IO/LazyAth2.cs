using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO {

    class LazyAth2<T> {
        public Func<T> GetValue { get; private set; }
        public LazyAth2(Func<T> factory) {
            GetValue = () => {
                var value = factory();
                GetValue = () => value;
                return value;
            };
        }

        public LazyAth2() :this(() => (T)Activator.CreateInstance(typeof(T))) { }
    }
}
