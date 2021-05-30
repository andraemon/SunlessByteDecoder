using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers.ShopSerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Exchange
    {
		internal static Exchange Deserialize(BinaryReader bs)
		{
			Exchange exchange = new Exchange();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				exchange.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				exchange.Image = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				exchange.Title = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				exchange.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				exchange.Shops = new List<Shop>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					exchange.Shops.Add(BinarySerializer_Shop.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				exchange.SettingIds = new List<int>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					exchange.SettingIds.Add(bs.ReadInt32());
				}
			}
			exchange.Id = bs.ReadInt32();
			return exchange;
		}

		internal static List<Exchange> DeserializeCollection(BinaryReader bs)
		{
			List<Exchange> list = new List<Exchange>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
