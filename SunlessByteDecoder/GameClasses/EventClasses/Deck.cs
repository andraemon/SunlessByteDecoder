using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.EventClasses
{
    public class Deck : Entity
    {
        public virtual World World { get; set; }
		public virtual string Name { get; set; }
		public virtual string ImageName { get; set; }
		public virtual int Ordering { get; set; }
		public virtual string Description { get; set; }
		public virtual Frequency Availability { get; set; }
		public virtual int DrawSize { get; set; }
		public virtual int MaxCards { get; set; }
	}
}
