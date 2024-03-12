using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Company
    {
        private string title;
        private string data;
        private int countPeople;

        public string Title { get => title; protected set => title = value; }
        public string Data { get => data; }
        public int CountPeople { get => countPeople; private set => countPeople = value; }
    }
}
