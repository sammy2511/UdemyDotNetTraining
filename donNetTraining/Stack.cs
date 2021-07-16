using System;
using System.Collections.Generic;

namespace donNetTraining
{
    class Stack
    {
        private List<Object> _stackList;
        private int _top;
        public Stack()
        {
            _stackList = new List<object>();
            _top = -1;
        }

        public void Push(Object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException();
            }
            _stackList.Add(obj);
            _top += 1;


        }

        public Object Pop()
        {
            if(_top == -1)
            {
                throw new InvalidOperationException();
            }
            var obj = _stackList[_top];
            _top -= 1;
            return obj;

        }

        public void Clear()
        {
            _top = -1;
            _stackList.Clear();
        }


    }
}

