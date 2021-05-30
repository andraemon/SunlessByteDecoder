using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.PersonaClasses;
using SunlessByteDecoder.BinarySerializer.PersonaSerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Setting
    {
        internal static Setting Deserialize(BinaryReader bs)
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

		internal static List<Setting> DeserializeCollection(BinaryReader bs)
		{
			List<Setting> list = new List<Setting>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
