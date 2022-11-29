using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrometricGeometry
{
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract decimal Perimeter { get; }
        public abstract decimal Area { get; }
    }
}
