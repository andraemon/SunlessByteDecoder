using SunlessByteDecoder.BinarySerializer.GeneralSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.PersonaSerializers
{
    public class BinarySerializer_Persona
    {
		internal static Persona Deserialize(BinaryReader bs)
		{
			Persona persona = new Persona();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				persona.QualitiesAffected = new List<PersonaQEffect>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					persona.QualitiesAffected.Add(BinarySerializer_PersonaQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				persona.QualitiesRequired = new List<PersonaQRequirement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					persona.QualitiesRequired.Add(BinarySerializer_PersonaQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				persona.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				persona.OwnerName = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				persona.Setting = BinarySerializer_Setting.Deserialize(bs);
			}
			persona.DateTimeCreated = BinarySerializer_DateTime.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				persona.Name = bs.ReadString();
			}
			persona.Id = bs.ReadInt32();
			return persona;
		}

		internal static List<Persona> DeserializeCollection(BinaryReader bs)
		{
			List<Persona> list = new List<Persona>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
