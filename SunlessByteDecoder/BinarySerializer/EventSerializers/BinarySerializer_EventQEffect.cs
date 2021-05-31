using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_EventQEffect
    {
		public static EventQEffect Deserialize(BinaryReader bs)
		{
			EventQEffect eventQEffect = new EventQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.Priority = new int?(bs.ReadInt32());
			}
			eventQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				eventQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				eventQEffect.CompletionMessage = bs.ReadString();
			}
			eventQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				eventQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			eventQEffect.Id = bs.ReadInt32();
			return eventQEffect;
		}

		public static void Serialize(BinaryWriter bs, EventQEffect o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.Priority != null)
			{
				bs.Write(true);
				bs.Write(o.Priority.Value);
			}
			else
			{
				bs.Write(false);
			}
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
