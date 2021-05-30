using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ProspectClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers
{
    public class BinarySerializer_ProspectQEffect
    {
        internal static ProspectQEffect Deserialize(BinaryReader bs)
		{
			ProspectQEffect prospectQEffect = new ProspectQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			prospectQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				prospectQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				prospectQEffect.CompletionMessage = bs.ReadString();
			}
			prospectQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				prospectQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			prospectQEffect.Id = bs.ReadInt32();
			return prospectQEffect;
		}
	}
}
