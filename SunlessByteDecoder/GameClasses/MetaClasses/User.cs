using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.MetaClasses
{
    public class User : Entity
    {
        public User()
        {
            EmailVerified = false;
            CreatedAt = DateTime.Now;
            ConfirmationCode = Guid.NewGuid().ToString();
            WorldPrivileges = new List<UserWorldPrivilege>();
            QualitiesPossessedList = new List<UserQPossession>();
            MessageAboutAnnouncements = true;
            MessageAboutNastiness = true;
            MessageAboutNiceness = true;
            StoryEventMessage = true;
            DefaultPrivilegeLevel = PrivilegeLevel.User;
        }
        public virtual IList<UserQPossession> QualitiesPossessedList { get; set; }
        public virtual string Name { get; set; }
        public virtual World StartedInWorld { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string FacebookEmail { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string ConfirmationCode { get; set; }
        public virtual long? TwitterId { get; set; }
        public virtual long? FacebookId { get; set; }
        public virtual string GoogleId { get; set; }
        public virtual string GoogleAuthToken { get; set; }
        public virtual string GoogleAuthTokenSecret { get; set; }
        public virtual string GoogleEmail { get; set; }
        public virtual string TwitterAuthToken { get; set; }
        public virtual string TwitterAuthTokenSecret { get; set; }
        public virtual string FacebookAuthToken { get; set; }
        public virtual string FacebookAuthTokenSecret { get; set; }
        public virtual string Source { get; set; }
        public virtual int EnteredViaContentId { get; set; }
        public virtual int EnteredViaCharacterId { get; set; }
        public virtual UserStatus Status { get; set; }
        public virtual bool EmailVerified { get; set; }
        public virtual ViaNetwork EchoViaNetwork { get; set; }
        public virtual ViaNetwork MessageViaNetwork { get; set; }
        public virtual bool MessageAboutNastiness { get; set; }
        public virtual bool MessageAboutNiceness { get; set; }
        public virtual bool MessageAboutAnnouncements { get; set; }
        public virtual bool StoryEventMessage { get; set; }
        public virtual PrivilegeLevel DefaultPrivilegeLevel { get; set; }
        public virtual LoggedInVia LoggedInVia { get; set; }
        public virtual bool IsBroadcastTarget { get; set; }
        public virtual int MysteryPrizeTracking { get; set; }
        public virtual int Recruited { get; set; }
        public virtual string TempId { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual DateTime? LastLoggedInAt { get; set; }
        public virtual DateTime? LastActiveAt { get; set; }
        public virtual string IP { get; set; }
        public virtual string LastAccessCode { get; set; }
        public virtual IList<UserWorldPrivilege> WorldPrivileges { get; set; }
        public virtual int SRPurchasedNexInLifetime { get; set; }
        public virtual int FatePointsGainedThroughGameInLifetime { get; set; }
        public virtual int Nex { get; set; }
    }
}
