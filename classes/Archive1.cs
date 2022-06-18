using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace gestion_hotelier.classes
{
    public class Archive
    {
        db db1;


        public int id { get; set; }
        public DateTime debut { get; set; }
        public DateTime fin { get; set; }
        public int montant { get; set; }
        public string chambre { get; set; }
        public string hotel { get; set; }
    }
}