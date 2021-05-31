using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.BargainClasses
{
    public class BargainQRequirement : BaseQRequirement
    {
        public string CustomLockedMessage { get; set; }
        public string CustomUnlockedMessage { get; set; }
    }
}
