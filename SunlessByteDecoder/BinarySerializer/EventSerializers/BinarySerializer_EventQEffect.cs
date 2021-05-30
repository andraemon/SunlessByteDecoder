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
		internal static EventQEffect Deserialize(BinaryReader bs)
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
	}
}
