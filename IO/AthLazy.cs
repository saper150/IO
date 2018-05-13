using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO {
    class AthLazy<T> {
        private T _instance;
        private Func<T> _factory;

        public bool IsValueCreated { get { return _instance != null; } }

        public T Value {
            get {
                if (_instance == null) {
                    if (_factory != null) {
                        _instance = _factory();
                    }
                    else {
                        _instance = (T)Activator.CreateInstance(typeof(T));
                    }
                    return _instance;
                }
                else {
                    return _instance;
                }
            }
        }

        public AthLazy(Func<T> factory) {
            _factory = factory;
        }
        public AthLazy() { }
    }
}
