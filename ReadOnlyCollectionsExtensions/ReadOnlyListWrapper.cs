﻿using System.Collections;
using System.Collections.Generic;

namespace System.Collections.Generic {
    public class ReadOnlyListWrapper<T> : IReadOnlyList<T> {
        private readonly IList<T> list;

        public ReadOnlyListWrapper(IList<T> list) {
            this.list = list;
        }

        public IEnumerator<T> GetEnumerator() {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return list.GetEnumerator();
        }

        public int Count {
            get { return list.Count; }
        }

        public T this[int key] {
            get { return list[key]; }
        }
    }
}