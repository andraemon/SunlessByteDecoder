using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers.ShopSerializers
{
    public class BinarySerializer_Shop
    {
		internal static Shop Deserialize(BinaryReader bs)
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
	}
}
