using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses
{
    internal class Domicile : Entity
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string ImageName { get; set; }
        public virtual int MaxHandSize { get; set; }
        public virtual int DefenceBonus { get; set; }
        public virtual World World { get; set; }
    }
}
