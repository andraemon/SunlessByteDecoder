using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ActClasses
{
    public class ActInviterQRequirement : BaseQRequirement
    {
		public ActInviterQRequirement()
		{
			Direction = RelationshipDirection.NoDirection;
		}
		public virtual int? DifficultyLevel { get; set; }
		public virtual RelationshipDirection Direction { get; set; }
		public virtual bool VisibleWhenRequirementFailed { get; set; }
	}
}
