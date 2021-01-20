using System;
using System.Collections.Generic;
using System.Text;

namespace HalloWelt
{
    class Handy
    {
        private string _hersteller;  // the name field
        public string Hersteller => _hersteller;     // the Name property

        public Handy(string hersteller)
        {
            this._hersteller = hersteller;            
        }


    }
}
