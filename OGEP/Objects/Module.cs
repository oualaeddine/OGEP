using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGEP.Objects
{
    class Module
    {
        public int moduleId { get; set; }

        public int matiereId { get; set; }
        public int niveauId { get; set; }
        public int profId { get; set; }
        public Module(int matiereId, int niveauId)
        {
            this.matiereId = matiereId;
            this.niveauId = niveauId;
        }

        public Module(int moduleId)
        {
            this.moduleId = moduleId;
        }
    }
}
