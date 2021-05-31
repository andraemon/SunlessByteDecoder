using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers.ShopSerializers
{
    public class BinarySerializer_Shop
    {
		public static Shop Deserialize(BinaryReader bs)
		{
			Shop shop = new Shop();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				shop.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				shop.Image = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				shop.Description = bs.ReadString();
			}
			shop.Ordering = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				shop.Exchange = BinarySerializer_Exchange.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				shop.Availabilities = new List<Availability>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					shop.Availabilities.Add(BinarySerializer_Availability.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				shop.QualitiesRequired = new List<ShopQRequirement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					shop.QualitiesRequired.Add(BinarySerializer_ShopQRequirement.Deserialize(bs));
				}
			}
			shop.Id = bs.ReadInt32();
			return shop;
		}

		public static void Serialize(BinaryWriter bs, Shop o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Image != null)
			{
				bs.Write(true);
				bs.Write(o.Image);
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
			bs.Write(o.Ordering);
			if (o.Exchange != null)
			{
				bs.Write(true);
				BinarySerializer_Exchange.Serialize(bs, o.Exchange);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Availabilities != null)
			{
				bs.Write(true);
				bs.Write(o.Availabilities.Count);
				foreach (Availability o2 in o.Availabilities)
				{
					BinarySerializer_Availability.Serialize(bs, o2);
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
				foreach (ShopQRequirement o3 in o.QualitiesRequired)
				{
					BinarySerializer_ShopQRequirement.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
