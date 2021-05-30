using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses
{
    internal class Setting : EntityWithName
    {
		public Setting()
		{
			this.Personae = new List<Persona>();
		}
		public virtual World World { get; set; }
		public virtual string OwnerName { get; set; }
		public virtual IList<Persona> Personae { get; set; }
		public virtual Area StartingArea { get; set; }
		public virtual Domicile StartingDomicile { get; set; }
		public virtual bool ItemsUsableHere { get; set; }
		public virtual Exchange Exchange { get; set; }
		public virtual int TurnLengthSeconds { get; set; }
		public virtual int MaxActionsAllowed { get; set; }
		public virtual int MaxCardsAllowed { get; set; }
		public virtual int ActionsInPeriodBeforeExhaustion { get; set; }
		public virtual string Description { get; set; }
	}
}
