using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SunlessByteDecoder.GameClasses.QualityClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.MetaClasses;
using SunlessByteDecoder.GameClasses.EventClasses.LivingStoryClasses;
using SunlessByteDecoder.GameClasses.EventClasses.BranchClasses;

namespace SunlessByteDecoder.GameClasses.EventClasses
{
	public class Event : EntityWithName
    {
        public Event()
        {
			QualitiesAffected = new List<EventQEffect>();
			QualitiesRequired = new List<EventQRequirement>();
			ChildBranches = new List<Branch>();
			DateTimeCreated = DateTime.Now;
			Urgency = Urgency.Normal;
			Category = EventCategory.Unspecialised;
			Autofire = true;
			Stickiness = 0;
			ExoticEffects = string.Empty;
		}
        public virtual IList<Branch> ChildBranches { get; set; }
        public virtual Branch ParentBranch { get; set; }
        public virtual IList<EventQEffect> QualitiesAffected { get; set; }
        public virtual List<EventQRequirement> QualitiesRequired { get; set; }
        public virtual string Image { get; set; }
        public virtual string SecondImage { get; set; }
        public virtual string Description { get; set; }
        public virtual string Tag { get; set; }
        public virtual string ExoticEffects { get; set; }
        public virtual string Note { get; set; }
        public virtual int ChallengeLevel { get; set; }
        public virtual DateTime? UnclearedEditAt { get; set; }
        public virtual User LastEditedBy { get; set; }
        public virtual float Ordering { get; set; }
        public virtual bool ShowAsMessage { get; set; }
        public virtual LivingStory LivingStory { get; set; }
        public virtual Event LinkToEvent { get; set; }
        public virtual Deck Deck { get; set; }
        public virtual EventCategory Category { get; set; }
        public virtual Area LimitedToArea { get; set; }
        public virtual World World { get; set; }
        public virtual bool Transient { get; set; }
        public virtual int Stickiness { get; set; }
        public virtual int MoveToAreaId { get; set; }
        public virtual Area MoveToArea { get; set; }
        public virtual Domicile MoveToDomicile { get; set; }
        public virtual Setting SwitchToSetting { get; set; }
        public virtual int FatePointsChange { get; set; }
        public virtual int BootyValue { get; set; }
        public virtual Quality LogInJournalAgainstQuality { get; set; }
        public virtual Setting Setting { get; set; }
        public virtual Urgency Urgency { get; set; }
		public virtual string Teaser
		{
			get
			{
				if (string.IsNullOrEmpty(Description))
				{
					return Description;
				}
				int periodIndex = Description.IndexOf(".");
				int erotemeIndex = Description.IndexOf("?");
				int ecphonemeIndex = Description.IndexOf("!");
				int emdashIndex = Description.IndexOf("—");
				periodIndex = ((periodIndex != -1) ? periodIndex : Description.Length);
				erotemeIndex = ((erotemeIndex != -1) ? erotemeIndex : Description.Length);
				ecphonemeIndex = ((ecphonemeIndex != -1) ? ecphonemeIndex : Description.Length);
				emdashIndex = ((emdashIndex != -1) ? emdashIndex : Description.Length);
				string doubleQuote = "\"";
				int doubleQuoteIndex = Description.IndexOf(doubleQuote, Description.IndexOf(doubleQuote) + 1);
				doubleQuoteIndex = ((doubleQuoteIndex != -1) ? doubleQuoteIndex : Description.Length);
				int preQuote = -1;
				string finisher = string.Empty;
				if (doubleQuoteIndex < periodIndex && doubleQuoteIndex < erotemeIndex && doubleQuoteIndex < ecphonemeIndex && doubleQuoteIndex < emdashIndex)
				{
					preQuote = doubleQuoteIndex - 1;
					finisher = "...\"";
				}
				List<int> source = new List<int>
				{
					periodIndex,
					erotemeIndex,
					ecphonemeIndex,
					emdashIndex
				};
				int min = source.Min((int x) => x);
				if (min < doubleQuoteIndex)
				{
					preQuote = min;
					if (Description.Substring(preQuote).Contains('"'))
					{
						finisher = Description[preQuote] + "\"";
					}
					else
					{
						finisher = Description[preQuote].ToString();
					}
				}
				if (preQuote != -1)
				{
					string text = Description.Substring(0, preQuote) + finisher;
					if (Description[preQuote..].Contains(']') && text.Contains('['))
					{
						text += "]";
					}
					return text;
				}
				return Description;
			}
			set
			{
			}
		}
		public virtual string OwnerName { get; set; }
		public virtual DateTime DateTimeCreated { get; set; }
		public virtual int Distribution { get; set; }
		public virtual bool Autofire { get; set; }
		public virtual bool CanGoBack { get; set; }
	}
}
