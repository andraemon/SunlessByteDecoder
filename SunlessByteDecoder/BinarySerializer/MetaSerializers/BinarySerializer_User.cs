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
		public static User Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, User o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.QualitiesPossessedList != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesPossessedList.Count);
				foreach (UserQPossession o2 in o.QualitiesPossessedList)
				{
					BinarySerializer_UserQPossession.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			if (o.StartedInWorld != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.StartedInWorld);
			}
			else
			{
				bs.Write(false);
			}
			if (o.EmailAddress != null)
			{
				bs.Write(true);
				bs.Write(o.EmailAddress);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FacebookEmail != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookEmail);
			}
			else
			{
				bs.Write(false);
			}
			if (o.PasswordHash != null)
			{
				bs.Write(true);
				bs.Write(o.PasswordHash);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ConfirmationCode != null)
			{
				bs.Write(true);
				bs.Write(o.ConfirmationCode);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterId != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterId.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FacebookId != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookId.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.GoogleId != null)
			{
				bs.Write(true);
				bs.Write(o.GoogleId);
			}
			else
			{
				bs.Write(false);
			}
			if (o.GoogleAuthToken != null)
			{
				bs.Write(true);
				bs.Write(o.GoogleAuthToken);
			}
			else
			{
				bs.Write(false);
			}
			if (o.GoogleAuthTokenSecret != null)
			{
				bs.Write(true);
				bs.Write(o.GoogleAuthTokenSecret);
			}
			else
			{
				bs.Write(false);
			}
			if (o.GoogleEmail != null)
			{
				bs.Write(true);
				bs.Write(o.GoogleEmail);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterAuthToken != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterAuthToken);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterAuthTokenSecret != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterAuthTokenSecret);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FacebookAuthToken != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookAuthToken);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FacebookAuthTokenSecret != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookAuthTokenSecret);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Source != null)
			{
				bs.Write(true);
				bs.Write(o.Source);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.EnteredViaContentId);
			bs.Write(o.EnteredViaCharacterId);
			BinarySerializer_UserStatus.Serialize(bs, o.Status);
			bs.Write(o.EmailVerified);
			BinarySerializer_ViaNetwork.Serialize(bs, o.EchoViaNetwork);
			BinarySerializer_ViaNetwork.Serialize(bs, o.MessageViaNetwork);
			bs.Write(o.MessageAboutNastiness);
			bs.Write(o.MessageAboutNiceness);
			bs.Write(o.MessageAboutAnnouncements);
			bs.Write(o.StoryEventMessage);
			BinarySerializer_PrivilegeLevel.Serialize(bs, o.DefaultPrivilegeLevel);
			BinarySerializer_LoggedInVia.Serialize(bs, o.LoggedInVia);
			bs.Write(o.IsBroadcastTarget);
			bs.Write(o.MysteryPrizeTracking);
			bs.Write(o.Recruited);
			if (o.TempId != null)
			{
				bs.Write(true);
				bs.Write(o.TempId);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_DateTime.Serialize(bs, o.CreatedAt);
			if (o.LastLoggedInAt != null)
			{
				bs.Write(true);
				BinarySerializer_DateTime.Serialize(bs, o.LastLoggedInAt.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LastActiveAt != null)
			{
				bs.Write(true);
				BinarySerializer_DateTime.Serialize(bs, o.LastActiveAt.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.IP != null)
			{
				bs.Write(true);
				bs.Write(o.IP);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LastAccessCode != null)
			{
				bs.Write(true);
				bs.Write(o.LastAccessCode);
			}
			else
			{
				bs.Write(false);
			}
			if (o.WorldPrivileges != null)
			{
				bs.Write(true);
				bs.Write(o.WorldPrivileges.Count);
				foreach (UserWorldPrivilege o3 in o.WorldPrivileges)
				{
					BinarySerializer_UserWorldPrivilege.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.SRPurchasedNexInLifetime);
			bs.Write(o.FatePointsGainedThroughGameInLifetime);
			bs.Write(o.Nex);
			bs.Write(o.Id);
		}
	}
}
