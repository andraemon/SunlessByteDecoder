using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.EventClasses.LivingStoryClasses
{
    internal class LivingStory : Entity
    {
        public LivingStory()
        {
            QualitiesAffected = new List<LivingStoryQEffect>();
            QualitiesRequired = new List<LivingStoryQRequirement>();
        }
        public virtual string ImageName { get; set; }
        public virtual World World { get; set; }
        public virtual string Name { get; set; }
        public virtual string Message { get; set; }
        public virtual string TwitterMessage { get; set; }
        public virtual string Tag { get; set; }
        public virtual string SubscriptionMessage { get; set; }
        public virtual int AfterHours { get; set; }
        public virtual bool Monetizable { get; set; }
        public virtual int NexCost { get; set; }
        public virtual LivingStory LinkedLivingStory { get; set; }
        public virtual IList<LivingStoryQEffect> QualitiesAffected { get; set; }
        public virtual IList<LivingStoryQRequirement> QualitiesRequired { get; set; }

    }
}
