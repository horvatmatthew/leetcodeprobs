public class MyHashMap {
            private int m_key = 2069;
            private List<LinkedList<int[]>> _internal = new List<LinkedList<int[]>>();

            public MyHashMap()
            {
                for (int i = 0; i < m_key; i++)
                    _internal.Add(new LinkedList<int[]>());
            }

            public void Put(int key, int value)
            {
                foreach (var item in _internal[key % m_key])
                    if (item[0] == key)
                    {
                        item[1] = value;

                        return;
                    }

                _internal[key % m_key].AddLast(new int[] { key, value });
            }

            public int Get(int key)
            {
                foreach (var item in _internal[key % m_key])
                    if (item[0] == key)
                        return item[1];

                return -1;
            }

            public void Remove(int key)
            {
                int[] node = null;

                foreach (var item in _internal[key % m_key])
                    if (item[0] == key)
                    {
                        node = item;
                        break;
                    }

                _internal[key % m_key].Remove(node);
            }
}