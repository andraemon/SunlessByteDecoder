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
		public static ActQEffect Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, ActQEffect o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
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
