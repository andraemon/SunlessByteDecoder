using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.BargainClasses
{
    internal class Bargain : EntityWithName
    {
		public virtual World World { get; set; }
		public virtual string Tags { get; set; }
		public virtual string Description { get; set; }
		public virtual Quality Offer { get; set; }
		public virtual int Stock { get; set; }
		public virtual string Price { get; set; }
		public virtual IList<BargainQRequirement> QualitiesRequired { get; set; }
		public virtual string Teaser
		{
			get
			{
				if (string.IsNullOrEmpty(Description))
				{
					return Description;
				}
				int periodIndex = Description.IndexOf(".");
				int ecphonemeIndex = Description.IndexOf("!");
				int erotemeIndex = Description.IndexOf("?");
				if (periodIndex == -1)
				{
					periodIndex = Description.Length;
				}
				if (ecphonemeIndex == -1)
				{
					ecphonemeIndex = Description.Length;
				}
				if (erotemeIndex == -1)
				{
					erotemeIndex = Description.Length;
				}
				if (periodIndex < ecphonemeIndex && periodIndex < erotemeIndex)
				{
					return Description.Substring(0, periodIndex + 1) + "..";
				}
				if (ecphonemeIndex < periodIndex && ecphonemeIndex < erotemeIndex)
				{
					return Description.Substring(0, ecphonemeIndex + 1) + " - ";
				}
				if (erotemeIndex < periodIndex && erotemeIndex < ecphonemeIndex)
				{
					return Description.Substring(0, erotemeIndex + 1);
				}
				if (Description.Length > 200)
				{
					return Description.Substring(0, 200) + "...";
				}
				return Description;
			}
			set
			{
			}
		}
	}
}
