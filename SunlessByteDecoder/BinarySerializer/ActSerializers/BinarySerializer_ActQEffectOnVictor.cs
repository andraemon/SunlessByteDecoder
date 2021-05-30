using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_ActQEffectOnVictor
    {
		internal static ActQEffectOnVictor Deserialize(BinaryReader bs)
		{
			ActQEffectOnVictor actQEffectOnVictor = new ActQEffectOnVictor();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			actQEffectOnVictor.Mirroring = bs.ReadBoolean();
			actQEffectOnVictor.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.CompletionMessage = bs.ReadString();
			}
			actQEffectOnVictor.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				actQEffectOnVictor.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			actQEffectOnVictor.Id = bs.ReadInt32();
			return actQEffectOnVictor;
		}
	}
}
