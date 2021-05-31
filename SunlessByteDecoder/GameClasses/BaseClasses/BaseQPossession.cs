using System;
using System.Collections.Generic;
using System.Text;
using SunlessByteDecoder.GameClasses.QualityClasses;

namespace SunlessByteDecoder.GameClasses.BaseClasses
{
    public class BaseQPossession : BaseQAssocWithLevel
    {
        public virtual int XP { get; set; }
        public virtual int EffectiveLevelModifier { get; set; }
        public virtual Quality TargetQuality { get; set; }
        public virtual int? TargetLevel { get; set; }
        public virtual string CompletionMessage { get; set; }
    }
}
