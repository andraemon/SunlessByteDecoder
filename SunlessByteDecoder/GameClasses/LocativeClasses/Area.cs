using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses
{
	public class Area : EntityWithName
    {
        public virtual string Description { get; set; }
        public virtual string ImageName { get; set; }
        public virtual World World { get; set; }
		public virtual bool MarketAccessPermitted { get; set; }
		public virtual string MoveMessage { get; set; }
		public virtual bool HideName { get; set; }
		public virtual bool RandomPostcard { get; set; }
		public virtual int MapX { get; set; }
		public virtual int MapY { get; set; }
		public virtual Quality UnlocksWithQuality { get; set; }
		public virtual bool ShowOps { get; set; }
		public virtual bool PremiumSubRequired { get; set; }
	}
}
