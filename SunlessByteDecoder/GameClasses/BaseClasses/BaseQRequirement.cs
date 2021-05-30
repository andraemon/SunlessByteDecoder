using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.BaseClasses
{
    internal class BaseQRequirement : BaseQAssoc
    {
        public virtual int? MinLevel { get; set; }
        public virtual int? MaxLevel { get; set; }
        public virtual string MinAdvanced { get; set; }
        public virtual string MaxAdvanced { get; set; }
    }
}
