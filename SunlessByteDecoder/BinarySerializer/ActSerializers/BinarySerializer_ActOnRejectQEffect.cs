using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_ActOnRejectQEffect
    {
		internal static ActOnRejectQEffect Deserialize(BinaryReader bs)
		{
			ActOnRejectQEffect actOnRejectQEffect = new ActOnRejectQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			actOnRejectQEffect.Mirroring = bs.ReadBoolean();
			actOnRejectQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.CompletionMessage = bs.ReadString();
			}
			actOnRejectQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				actOnRejectQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			actOnRejectQEffect.Id = bs.ReadInt32();
			return actOnRejectQEffect;
		}
	}
}
