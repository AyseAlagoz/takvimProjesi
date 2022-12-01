using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entities
{
   
        public class plans
        {
            public DateTime Tarih { get; set; }
            public string Planlar { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Tarih, Planlar);
        }
       

    }
    
}
