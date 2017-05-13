using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscGolfTracker
{
    class Throw
    {
        //Support class to containt Throw objects from the Throw Table in the database. 
        public int ThrowId { get; set; }
        public int DiscId { get; set; }
        public string ThrowType { get; set; }
        public int Distance { get; set; }
        public int Accuracy { get; set; }
        public int ThrowQuality { get; set; }
        public string Park { get; set; }
        public int Hole { get; set; }
    }
}
