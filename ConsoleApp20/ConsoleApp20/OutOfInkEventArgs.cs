using System;

namespace ConsoleApp20
{
    public class OutOfInkEventArgs : EventArgs
    {
        public object name;
        public object color;

        public OutOfInkEventArgs(object name)
        {
            this.name = name;
        }
    }
}