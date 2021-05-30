using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_AspectQPossession
    {
		internal static AspectQPossession Deserialize(BinaryReader bs)
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
	}
}
