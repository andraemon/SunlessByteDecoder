using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ActClasses
{
    public class ActQRequirement : BaseQRequirement
    {
		public ActQRequirement()
		{
			Direction = RelationshipDirection.AsSubject;
		}
		public virtual int? DifficultyLevel { get; set; }
		public virtual RelationshipDirection Direction { get; set; }
	}
}
