using SunlessByteDecoder.GameClasses.ActClasses;
using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.EventClasses.BranchClasses
{
    internal class Branch : EntityWithName
    {
        public Branch()
        {
			QualitiesRequired = new List<BranchQRequirement>();
			DateTimeCreated = DateTime.Now;
		}
		public virtual Event SuccessEvent { get; set; }
		public virtual Event DefaultEvent { get; set; }
		public virtual Event RareDefaultEvent { get; set; }
		public virtual int RareDefaultEventChance { get; set; }
		public virtual Event RareSuccessEvent { get; set; }
		public virtual int RareSuccessEventChance { get; set; }
		public virtual Event ParentEvent { get; set; }
		public virtual IList<BranchQRequirement> QualitiesRequired { get; set; }
		public virtual string Image { get; set; }
		public virtual string Description { get; set; }
		public virtual string OwnerName { get; set; }
		public virtual DateTime DateTimeCreated { get; set; }
		public virtual int CurrencyCost { get; set; }
		public virtual bool Archived { get; set; }
		public virtual Category? RenameQualityCategory { get; set; }
		public virtual string ButtonText { get; set; }
		public virtual int Ordering { get; set; }
		public virtual Act Act { get; set; }
		public virtual int ActionCost { get; set; }
	}
}
