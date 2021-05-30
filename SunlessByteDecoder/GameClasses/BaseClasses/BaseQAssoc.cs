using System;
using System.Collections.Generic;
using System.Text;
using SunlessByteDecoder.GameClasses.QualityClasses;

namespace SunlessByteDecoder.GameClasses.BaseClasses
{
    internal class BaseQAssoc : Entity
    {
        public virtual Quality AssociatedQuality { get; set; }
    }
}
