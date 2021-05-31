using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.EventClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ActClasses
{
    public class Act : Entity
    {
        public Act()
        {
            QualitiesRequiredOnInviter = new List<ActInviterQRequirement>();
            QualitiesAffectedOnInviterOnRejection = new List<ActOnRejectQEffect>();
            QualitiesAffectedOnTarget = new List<ActQEffect>();
            QualitiesAffectedOnVictor = new List<ActQEffectOnVictor>();
            QualitiesRequired = new List<ActQRequirement>();
            InvitationRestriction = InvitationRestriction.SameInstanceOnly;
            SSAbilityType = "Attack";
            SSAbilityAnimation = "Default";
        }
        public virtual string Name { get; set; }
        public virtual string ImageName { get; set; }
        public virtual InteractionType InteractionType { get; set; }
        public virtual string Tag { get; set; }
        public virtual ActUrgency Urgency { get; set; }
        public virtual InvitationDomain InvitationDomain { get; set; }
        public virtual InvitationRestriction InvitationRestriction { get; set; }
        public virtual string InviteMessage { get; set; }
        public virtual string TwitterInviteMessage { get; set; }
        public virtual string AcceptMessage { get; set; }
        public virtual string CooperativeCompletionMessage { get; set; }
        public virtual string WinMessage { get; set; }
        public virtual string LoseMessage { get; set; }
        public virtual string InviterModifier { get; set; }
        public virtual bool IsUnique { get; set; }
        public virtual Quality AssociatedQuality { get; set; }
        public virtual int? Cooldown { get; set; }
        public virtual Event SocialEvent { get; set; }
        public virtual Quality ChallengeOn { get; set; }
        public virtual int ParticipantsRequired { get; set; }
        public virtual IList<ActQEffect> QualitiesAffectedOnTarget { get; set; }
        public virtual IList<ActQEffectOnVictor> QualitiesAffectedOnVictor { get; set; }
        public virtual IList<ActQRequirement> QualitiesRequired { get; set; }
        public virtual IList<ActInviterQRequirement> QualitiesRequiredOnInviter { get; set; }
        public virtual IList<ActOnRejectQEffect> QualitiesAffectedOnInviterOnRejection { get; set; }
        public virtual string SSAbilityType { get; set; }
        public virtual string SSAbilityAnimation { get; set; }
        public virtual World World { get; set; }
    }
}
