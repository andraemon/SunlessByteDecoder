using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_AspectQPossession
    {
		public static AspectQPossession Deserialize(BinaryReader bs)
		{
			AspectQPossession aspectQPossession = new AspectQPossession();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				aspectQPossession.Quality = BinarySerializer_Quality.Deserialize(bs);
			}
			aspectQPossession.XP = bs.ReadInt32();
			aspectQPossession.EffectiveLevelModifier = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				aspectQPossession.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				aspectQPossession.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				aspectQPossession.CompletionMessage = bs.ReadString();
			}
			aspectQPossession.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				aspectQPossession.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			aspectQPossession.Id = bs.ReadInt32();
			return aspectQPossession;
		}

		public static void Serialize(BinaryWriter bs, AspectQPossession o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.Quality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.Quality);
			}
			else
			{
				bs.Write(false);
			}
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
