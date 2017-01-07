using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteurBelotteWindowsForm
{
   abstract class Command
    {
        public abstract void Redo();
        public abstract void Undo();
    }
}
