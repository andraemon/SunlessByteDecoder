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
		public static ActOnRejectQEffect Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, ActOnRejectQEffect o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			bs.Write(o.Mirroring);
			bs.Write(o.ForceEquip);
			if (o.OnlyIfNoMoreThanAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.OnlyIfNoMoreThanAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.OnlyIfAtLeast != null)
			{
				bs.Write(true);
				bs.Write(o.OnlyIfAtLeast.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.OnlyIfNoMoreThan != null)
			{
				bs.Write(true);
				bs.Write(o.OnlyIfNoMoreThan.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SetToExactlyAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.SetToExactlyAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ChangeByAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.ChangeByAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.OnlyIfAtLeastAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.OnlyIfAtLeastAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SetToExactly != null)
			{
				bs.Write(true);
				bs.Write(o.SetToExactly.Value);
			}
			else
			{
				bs.Write(false);
			}
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
