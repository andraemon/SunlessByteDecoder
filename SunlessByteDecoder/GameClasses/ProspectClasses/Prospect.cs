using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ProspectClasses
{
	public class Prospect : EntityWithName
    {
		public Prospect()
		{
			Completions = new List<Completion>();
		}
		public virtual World World { get; set; }
		public virtual string Tags { get; set; }
		public virtual string Description { get; set; }
		public virtual Setting Setting { get; set; }
		public virtual Quality Request { get; set; }
		public virtual int Demand { get; set; }
		public virtual string Payment { get; set; }
		public virtual IList<ProspectQEffect> QualitiesAffected { get; set; }
		public virtual IList<ProspectQRequirement> QualitiesRequired { get; set; }
		public virtual IList<Completion> Completions { get; set; }
	}
}
