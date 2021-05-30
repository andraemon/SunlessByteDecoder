using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers.CompletionSerializers
{
    public class BinarySerializer_CompletionQEffect
    {
        internal static CompletionQEffect Deserialize(BinaryReader bs)
		{
			CompletionQEffect completionQEffect = new CompletionQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			completionQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				completionQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				completionQEffect.CompletionMessage = bs.ReadString();
			}
			completionQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				completionQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			completionQEffect.Id = bs.ReadInt32();
			return completionQEffect;
		}
	}
}
