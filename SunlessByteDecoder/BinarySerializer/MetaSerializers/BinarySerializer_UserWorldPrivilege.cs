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
		internal static UserWorldPrivilege Deserialize(BinaryReader bs)
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
	}
}
