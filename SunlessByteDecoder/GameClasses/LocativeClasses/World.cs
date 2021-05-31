using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses
{
	public class World : Entity
    {
		public World()
		{
			LastUpdated = DateTime.Now;
			Genre = Genre.NotYetSpecified;
			PublishState = PublishState.InProgress;
			ShowCardTitles = true;
		}
		public virtual bool GeneralQualityCatalogue { get; set; }
        public virtual bool ShowCardTitles { get; set; }
        public virtual string CharacterCreationPageText { get; set; }
        public virtual string EndPageText { get; set; }
        public virtual string FrontPageText { get; set; }
        public virtual string CustomCss { get; set; }
        public virtual string Credits { get; set; }
        public virtual string Description { get; set; }
        public virtual string Name { get; set; }
        public virtual string Domain { get; set; }
        public virtual int Promoted { get; set; }
		public virtual Setting DefaultSetting { get; set; }
		public virtual bool FacebookAuth { get; set; }
		public virtual bool TwitterAuth { get; set; }
		public virtual bool EmailAuth { get; set; }
		public virtual string FacebookAPIKey { get; set; }
		public virtual string FacebookAppId { get; set; }
		public virtual string FacebookAppSecret { get; set; }
		public virtual string GameUserTwitterAuthToken { get; set; }
		public virtual string GameUserTwitterAuthTokenSecret { get; set; }
		public virtual string TwitterConsumerKey { get; set; }
		public virtual string TwitterConsumerSecret { get; set; }
		public virtual string TwitterCallbackUrl { get; set; }
		public virtual string AmazonHostedImageUrl { get; set; }
		public virtual string AmazonBucketName { get; set; }
		public virtual string StyleSheet { get; set; }
		public virtual string LogoImage { get; set; }
		public virtual Setting DefaultStartingSetting { get; set; }
		public virtual User Owner { get; set; }
		public virtual bool IsPortalWorld { get; set; }
		public virtual bool Monetizes { get; set; }
		public virtual string PaymentEmailAddress { get; set; }
		public virtual string SupportEmailAddress { get; set; }
		public virtual string SystemFromEmailAddress { get; set; }
		public virtual DateTime LastUpdated { get; set; }
		public virtual string UpdateNotes { get; set; }
		public virtual PublishState PublishState { get; set; }
		public virtual Genre Genre { get; set; }
	}
}
