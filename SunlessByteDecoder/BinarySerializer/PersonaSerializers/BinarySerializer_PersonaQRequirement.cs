using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.PersonaSerializers
{
    public class BinarySerializer_PersonaQRequirement
    {
        internal static PersonaQRequirement Deserialize(BinaryReader bs)
		{
			PersonaQRequirement personaQRequirement = new PersonaQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				personaQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				personaQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				personaQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				personaQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				personaQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			personaQRequirement.Id = bs.ReadInt32();
			return personaQRequirement;
		}
	}
}
