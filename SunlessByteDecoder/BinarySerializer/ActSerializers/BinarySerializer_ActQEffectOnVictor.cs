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
		public static ActQEffectOnVictor Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, ActQEffectOnVictor o)
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
