using SunlessByteDecoder.BinarySerializer.GeneralSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace SunlessByteDecoder.BinarySerializer.PersonaSerializers
{
    public class BinarySerializer_Persona
    {
		public static Persona Deserialize(BinaryReader bs)
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

		public static List<Persona> DeserializeCollection(BinaryReader bs)
		{
			List<Persona> list = new List<Persona>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Persona o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.QualitiesAffected != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffected.Count);
				foreach (PersonaQEffect o2 in o.QualitiesAffected)
				{
					BinarySerializer_PersonaQEffect.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesRequired != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesRequired.Count);
				foreach (PersonaQRequirement o3 in o.QualitiesRequired)
				{
					BinarySerializer_PersonaQRequirement.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
			}
			else
			{
				bs.Write(false);
			}
			if (o.OwnerName != null)
			{
				bs.Write(true);
				bs.Write(o.OwnerName);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Setting != null)
			{
				bs.Write(true);
				BinarySerializer_Setting.Serialize(bs, o.Setting);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_DateTime.Serialize(bs, o.DateTimeCreated);
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Persona> c)
		{
			bs.Write(c.Count());
			foreach (Persona o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
