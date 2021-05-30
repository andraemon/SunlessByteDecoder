using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.PersonaSerializers
{
    public class BinarySerializer_PersonaQEffect
    {
		internal static PersonaQEffect Deserialize(BinaryReader bs)
		{
			PersonaQEffect personaQEffect = new PersonaQEffect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			personaQEffect.ForceEquip = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				personaQEffect.OnlyIfNoMoreThanAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.OnlyIfAtLeast = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.OnlyIfNoMoreThan = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.SetToExactlyAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.ChangeByAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.OnlyIfAtLeastAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.SetToExactly = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.TargetQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.TargetLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				personaQEffect.CompletionMessage = bs.ReadString();
			}
			personaQEffect.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				personaQEffect.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			personaQEffect.Id = bs.ReadInt32();
			return personaQEffect;
		}
	}
}
