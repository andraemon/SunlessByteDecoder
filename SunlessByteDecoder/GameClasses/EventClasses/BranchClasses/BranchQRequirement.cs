using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.EventClasses.BranchClasses
{
    internal class BranchQRequirement : BaseQRequirement
    {
		public virtual int? DifficultyLevel { get; set; }
		public virtual string DifficultyAdvanced { get; set; }
		public virtual bool VisibleWhenRequirementFailed { get; set; }
		public virtual string CustomLockedMessage { get; set; }
		public virtual string CustomUnlockedMessage { get; set; }
		public virtual bool IsCostRequirement { get; set; }
	}
}
