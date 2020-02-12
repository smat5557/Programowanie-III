using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Poczta
    {
        public event EventHandler NowyMail;
        protected virtual void Wyslij(EventArgs Nadawca, EventArgs SkrotTresci)
        {
            //EventHandler NowyMail = Wyslij;
            NowyMail?.Invoke(this, Nadawca);
        }
    }
}
