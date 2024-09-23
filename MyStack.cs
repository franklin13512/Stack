using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProject
{
    internal class MyStack<T>
    {
        private MyList1<T> TheList;

        public MyStack()
        {
            TheList = new MyList1<T>();
        }

        public int Number
        {
            get { return TheList.Number;  }
        }

        public T Peek
        {
            get { return TheList[Number - 1]; }
        }

        public T Pop()
        {
            return TheList.RemoveAtLast();
        }

        public void Push(T NewData)
        {
            TheList.AddAtLast(NewData);
        }

        public bool IsEmpty()
        {
            if (TheList.Number == 0)
            {
                return true;
            }else { return false; }
        }

        public override string ToString()
        {
            return "The Stack: " + TheList.ToString() + " Top ";
        }
    }
}
