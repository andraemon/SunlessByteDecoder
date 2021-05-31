using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using SunlessByteDecoder.BinarySerializer.PersonaSerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Setting
    {
        public static Setting Deserialize(BinaryReader bs)
        {
			Setting setting = new Setting();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				setting.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				setting.OwnerName = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				setting.Personae = new List<Persona>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					setting.Personae.Add(BinarySerializer_Persona.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				setting.StartingArea = BinarySerializer_Area.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				setting.StartingDomicile = BinarySerializer_Domicile.Deserialize(bs);
			}
			setting.ItemsUsableHere = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				setting.Exchange = BinarySerializer_Exchange.Deserialize(bs);
			}
			setting.TurnLengthSeconds = bs.ReadInt32();
			setting.MaxActionsAllowed = bs.ReadInt32();
			setting.MaxCardsAllowed = bs.ReadInt32();
			setting.ActionsInPeriodBeforeExhaustion = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				setting.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				setting.Name = bs.ReadString();
			}
			setting.Id = bs.ReadInt32();
			return setting;
		}

		public static List<Setting> DeserializeCollection(BinaryReader bs)
		{
			List<Setting> list = new List<Setting>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Setting o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
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
			if (o.Personae != null)
			{
				bs.Write(true);
				bs.Write(o.Personae.Count);
				foreach (Persona o2 in o.Personae)
				{
					BinarySerializer_Persona.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.StartingArea != null)
			{
				bs.Write(true);
				BinarySerializer_Area.Serialize(bs, o.StartingArea);
			}
			else
			{
				bs.Write(false);
			}
			if (o.StartingDomicile != null)
			{
				bs.Write(true);
				BinarySerializer_Domicile.Serialize(bs, o.StartingDomicile);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.ItemsUsableHere);
			if (o.Exchange != null)
			{
				bs.Write(true);
				BinarySerializer_Exchange.Serialize(bs, o.Exchange);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.TurnLengthSeconds);
			bs.Write(o.MaxActionsAllowed);
			bs.Write(o.MaxCardsAllowed);
			bs.Write(o.ActionsInPeriodBeforeExhaustion);
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
			}
			else
			{
				bs.Write(false);
			}
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

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Setting> c)
		{
			bs.Write(c.Count());
			foreach (Setting o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
