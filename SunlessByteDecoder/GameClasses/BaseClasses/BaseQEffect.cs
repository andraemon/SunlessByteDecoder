using System;
using System.Collections.Generic;
using System.Text;
using SunlessByteDecoder.GameClasses.QualityClasses;

namespace SunlessByteDecoder.GameClasses.BaseClasses
{
    internal class BaseQEffect : BaseQAssocWithLevel
    {
        public virtual bool ForceEquip { get; set; }
        public virtual string OnlyIfNoMoreThanAdvanced { get; set; }
        public virtual int? OnlyIfAtLeast { get; set; }
        public virtual int? OnlyIfNoMoreThan { get; set; }
        public virtual string SetToExactlyAdvanced { get; set; }
        public virtual string ChangeByAdvanced { get; set; }
        public virtual string OnlyIfAtLeastAdvanced { get; set; }
        public virtual int? SetToExactly { get; set; }
        public virtual Quality TargetQuality { get; set; }
        public virtual int? TargetLevel { get; set; }
        public virtual string CompletionMessage { get; set; }
    }
}
