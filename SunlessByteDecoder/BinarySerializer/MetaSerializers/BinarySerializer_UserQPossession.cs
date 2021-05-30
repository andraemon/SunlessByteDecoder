using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_UserQPossession
    {
		internal static UserQPossession Deserialize(BinaryReader bs)
		{
			UserQPossession userQPossession = new UserQPossession();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			userQPossession.XP = bs.ReadInt32();
			userQPossession.EffectiveLevelModifier = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				userQPossession.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				userQPossession.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				userQPossession.CompletionMessage = bs.ReadString();
			}
			userQPossession.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				userQPossession.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			userQPossession.Id = bs.ReadInt32();
			return userQPossession;
		}
	}
}
