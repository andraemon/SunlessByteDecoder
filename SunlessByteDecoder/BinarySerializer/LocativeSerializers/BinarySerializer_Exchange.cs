using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers.ShopSerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Exchange
    {
		public static Exchange Deserialize(BinaryReader bs)
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

		public static List<Exchange> DeserializeCollection(BinaryReader bs)
		{
			List<Exchange> list = new List<Exchange>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Exchange o)
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
			if (o.Title != null)
			{
				bs.Write(true);
				bs.Write(o.Title);
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
			if (o.Shops != null)
			{
				bs.Write(true);
				bs.Write(o.Shops.Count);
				foreach (Shop o2 in o.Shops)
				{
					BinarySerializer_Shop.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.SettingIds != null)
			{
				bs.Write(true);
				bs.Write(o.SettingIds.Count);
				foreach (int value in o.SettingIds)
				{
					bs.Write(value);
				}
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Exchange> c)
		{
			bs.Write(c.Count());
			foreach (Exchange o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
