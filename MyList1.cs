using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CsProject
{
    internal class MyList1<T>
    {
        public T[] Data = new T[4];
        private int Count = 0;

        //访问动态数组容量
        public int Capacity
        {
            get { return Data.Length; }
        }

        //访问动态数组元素量
        public int Number
        {
            get { return Count; }
        }

        public void Add(int Index, T Value) 
        {
            if (Index < 0 || Index > Count ) 
            {
                throw new ArgumentOutOfRangeException("溢出");

            }
            else if (Count >= Data.Length)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else
            {
                for (int i = Count - 1; Index <= i; i--)
                {
                    Data[i + 1] = Data[i];
                }
                Data[Index] = Value;
                Count++;

                if (Count == Data.Length)
                {
                    T[] NewList = new T[Data.Length * 2];

                    for (int i = 0; i < Data.Length; i++)
                    {
                        NewList[i] = Data[i];
                    }
                    Data = NewList;
                }
            }
        }

        public void AddAtLast(T Value)
        {
            Add(Count, Value);
        }

        public void AddAtFirst(T Value)
        {
            Add(0, Value);
        }

        public T Remove(int Index)
        {
            if (Index < 0 || Index >= Count)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else 
            {
                T ReturnData = Data[Index];
                for (int i = Index; i < Count - 1; i++)
                {
                    Data[i] = Data[i + 1];
                }
                Data[Count - 1] = default(T);

                Count--;

                if (Count == Data.Length / 2)
                {
                    T[] NewList = new T[Data.Length / 2];

                    for (int i = 0; i < NewList.Length; i++)
                    {
                        NewList[i] = Data[i];
                    }
                    Data = NewList;
                }

                return ReturnData;
            }
        }

        public T RemoveAtFirst()
        {
           return Remove(0);
        }

        public T RemoveAtLast()
        {
           return Remove(Count - 1);
        }

        public void Setting(int Index, T NewData)
        {
            if (Index < 0 || Index >= Count)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else
            {
                Data[Index] = NewData;
            }
        }

        public void SetAtFirst(T NewData)
        {
            Setting(0, NewData);
        }

        public void SetAtLast(T NewData)
        {
            Setting(Count - 1, NewData);
        }

        public int Getting(T TargetData )
        {
            for (int i = 0; i < Count ; i++)
            {
                if (TargetData.Equals(Data[i]))
                {
                    return i;
                }
            }
            return default(int);
        }

        public T Getting(int Index)
        {
            if (Index < 0 || Index >= Count)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else
            {
                return Data[Index];
            }
        }

        public bool IsIncluded(T TargetData)
        {
            for (int i = 0; i < Count ; i++)
            {
                if (Data[i].Equals(TargetData))
                {
                    return true;
                }
            }
            return false;
        }


        public T this[int index]
        {
            get { return Data[index]; }
            set
            {
                Data[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.Append("[ ");

            for (int i = 0; i < Count; i++)
            {
                Sb.Append(Data[i]);
                if (i != Count - 1)
                {
                    Sb.Append(", ");
                }
            }
            Sb.Append(" ]");

            return Sb.ToString();
        }
    }
}
