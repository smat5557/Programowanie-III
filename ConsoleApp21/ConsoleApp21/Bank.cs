using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class Bank
    {

        private double StanKonta { get; set; }
        

        public delegate void TransakcjaDelegata(int idKlienta, double kwota, string TypTransakcji);
        public event TransakcjaDelegata Transakcja;
        public event EventHandler TransakcjaEventHandler;
        public delegate void EventHandlerTransakcja(object sender, EventArgs e);
        public delegate void EventHandlerTransakcja2(object sender, EventArgs e);


        public void Wplac(double kwota, int typTranskacji)
        {
            //Transakcja(TransakcjaDelegata Bank.idKlienta, typTransakcji);
       
        }

        public void Wyplac(double kwota, string typTranskacji)
        {

        }
    }
}
