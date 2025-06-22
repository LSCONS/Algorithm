using System;
using System.Collections.Generic;
using System.Linq;

    public class Solution
    {
        public int solution(int n, int k, int[] enemy)
        {
            int rounds = 0;
            var heap = new MinHeap(enemy.Length);

            foreach (int dmg in enemy)
            {
                heap.Push(dmg);

                if (heap.Count > k)
                {
                    n -= heap.Pop();
                }

                if (n < 0)
                    break;

                rounds++;
            }

            return rounds;
        }


        class MinHeap
        {
            int[] _data;
            public int Count { get; private set; }

            public MinHeap(int capacity)
            {
                _data = new int[capacity];
                Count = 0;
            }

            public void Push(int val)
            {
                int i = Count;
                _data[i] = val;
                Count++;

                while (i > 0)
                {
                    int p = (i - 1) >> 1;
                    if (_data[p] <= _data[i])
                        break;

                    Swap(p, i);
                    i = p;
                }
            }

            public int Pop()
            {
                int ret = _data[0];
                Count--;
                _data[0] = _data[Count];

                int i = 0;
                while (true)
                {
                    int left = (i << 1) + 1;
                    int right = left + 1;
                    int smallest = i;

                    if (left < Count && _data[left] < _data[smallest])
                        smallest = left;
                    if (right < Count && _data[right] < _data[smallest])
                        smallest = right;
                    if (smallest == i)
                        break;

                    Swap(i, smallest);
                    i = smallest;
                }

                return ret;
            }

            void Swap(int i, int j)
            {
                int tmp = _data[i];
                _data[i] = _data[j];
                _data[j] = tmp;
            }
        }
    }