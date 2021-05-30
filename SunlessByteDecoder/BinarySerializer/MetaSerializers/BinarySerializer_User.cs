using SunlessByteDecoder.BinarySerializer.GeneralSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_User
    {
		internal static User Deserialize(BinaryReader bs)
		{
			User user = new User();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				user.QualitiesPossessedList = new List<UserQPossession>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					user.QualitiesPossessedList.Add(BinarySerializer_UserQPossession.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				user.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.StartedInWorld = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				user.EmailAddress = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.FacebookEmail = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.PasswordHash = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.ConfirmationCode = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.TwitterId = new long?(bs.ReadInt64());
			}
			if (bs.ReadBoolean())
			{
				user.FacebookId = new long?(bs.ReadInt64());
			}
			if (bs.ReadBoolean())
			{
				user.GoogleId = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.GoogleAuthToken = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.GoogleAuthTokenSecret = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.GoogleEmail = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.TwitterAuthToken = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.TwitterAuthTokenSecret = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.FacebookAuthToken = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.FacebookAuthTokenSecret = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.Source = bs.ReadString();
			}
			user.EnteredViaContentId = bs.ReadInt32();
			user.EnteredViaCharacterId = bs.ReadInt32();
			user.Status = BinarySerializer_UserStatus.Deserialize(bs);
			user.EmailVerified = bs.ReadBoolean();
			user.EchoViaNetwork = BinarySerializer_ViaNetwork.Deserialize(bs);
			user.MessageViaNetwork = BinarySerializer_ViaNetwork.Deserialize(bs);
			user.MessageAboutNastiness = bs.ReadBoolean();
			user.MessageAboutNiceness = bs.ReadBoolean();
			user.MessageAboutAnnouncements = bs.ReadBoolean();
			user.StoryEventMessage = bs.ReadBoolean();
			user.DefaultPrivilegeLevel = BinarySerializer_PrivilegeLevel.Deserialize(bs);
			user.LoggedInVia = BinarySerializer_LoggedInVia.Deserialize(bs);
			user.IsBroadcastTarget = bs.ReadBoolean();
			user.MysteryPrizeTracking = bs.ReadInt32();
			user.Recruited = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				user.TempId = bs.ReadString();
			}
			user.CreatedAt = BinarySerializer_DateTime.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				user.LastLoggedInAt = new DateTime?(BinarySerializer_DateTime.Deserialize(bs));
			}
			if (bs.ReadBoolean())
			{
				user.LastActiveAt = new DateTime?(BinarySerializer_DateTime.Deserialize(bs));
			}
			if (bs.ReadBoolean())
			{
				user.IP = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.LastAccessCode = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				user.WorldPrivileges = new List<UserWorldPrivilege>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					user.WorldPrivileges.Add(BinarySerializer_UserWorldPrivilege.Deserialize(bs));
				}
			}
			user.SRPurchasedNexInLifetime = bs.ReadInt32();
			user.FatePointsGainedThroughGameInLifetime = bs.ReadInt32();
			user.Nex = bs.ReadInt32();
			user.Id = bs.ReadInt32();
			return user;
		}
	}
}
