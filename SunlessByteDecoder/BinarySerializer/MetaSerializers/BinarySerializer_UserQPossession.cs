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
		public static UserQPossession Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, UserQPossession o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			bs.Write(o.XP);
			bs.Write(o.EffectiveLevelModifier);
			if (o.TargetQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.TargetQuality);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TargetLevel != null)
			{
				bs.Write(true);
				bs.Write(o.TargetLevel.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CompletionMessage != null)
			{
				bs.Write(true);
				bs.Write(o.CompletionMessage);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Level);
			if (o.AssociatedQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.AssociatedQuality);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
