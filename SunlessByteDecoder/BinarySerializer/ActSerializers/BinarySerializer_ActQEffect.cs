using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_ActQEffect
    {
		internal static ActQEffect Deserialize(BinaryReader bs)
		{
			ActQEffect actQEffect = new ActQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			actQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				actQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				actQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffect.CompletionMessage = bs.ReadString();
			}
			actQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				actQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			actQEffect.Id = bs.ReadInt32();
			return actQEffect;
		}
	}
}
