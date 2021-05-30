using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ProspectClasses
{
    internal class ProspectQRequirement : BaseQRequirement
    {
		public virtual Prospect Prospect { get; set; }
		public string CustomLockedMessage { get; set; }
		public string CustomUnlockedMessage { get; set; }
	}
}
