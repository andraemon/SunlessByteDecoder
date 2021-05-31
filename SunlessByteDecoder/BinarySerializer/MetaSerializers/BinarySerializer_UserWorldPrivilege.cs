using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_UserWorldPrivilege
    {
		public static UserWorldPrivilege Deserialize(BinaryReader bs)
		{
			UserWorldPrivilege userWorldPrivilege = new UserWorldPrivilege();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				userWorldPrivilege.World = BinarySerializer_World.Deserialize(bs);
			}
			userWorldPrivilege.PrivilegeLevel = BinarySerializer_PrivilegeLevel.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				userWorldPrivilege.User = BinarySerializer_User.Deserialize(bs);
			}
			userWorldPrivilege.Id = bs.ReadInt32();
			return userWorldPrivilege;
		}

		public static void Serialize(BinaryWriter bs, UserWorldPrivilege o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_PrivilegeLevel.Serialize(bs, o.PrivilegeLevel);
			if (o.User != null)
			{
				bs.Write(true);
				BinarySerializer_User.Serialize(bs, o.User);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
