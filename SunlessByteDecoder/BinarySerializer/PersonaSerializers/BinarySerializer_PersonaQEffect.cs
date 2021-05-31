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
		public static PersonaQEffect Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, PersonaQEffect o)
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
