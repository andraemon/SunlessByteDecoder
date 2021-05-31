using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers.ShopSerializers
{
    public class BinarySerializer_Availability
    {
		public static Availability Deserialize(BinaryReader bs)
		{
			Availability availability = new Availability();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				availability.Quality = BinarySerializer_Quality.Deserialize(bs);
			}
			availability.Cost = bs.ReadInt32();
			availability.SellPrice = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				availability.InShop = BinarySerializer_Shop.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				availability.PurchaseQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				availability.BuyMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				availability.SellMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				availability.SaleDescription = bs.ReadString();
			}
			availability.Id = bs.ReadInt32();
			return availability;
		}

		public static void Serialize(BinaryWriter bs, Availability o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.Quality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.Quality);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Cost);
			bs.Write(o.SellPrice);
			if (o.InShop != null)
			{
				bs.Write(true);
				BinarySerializer_Shop.Serialize(bs, o.InShop);
			}
			else
			{
				bs.Write(false);
			}
			if (o.PurchaseQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.PurchaseQuality);
			}
			else
			{
				bs.Write(false);
			}
			if (o.BuyMessage != null)
			{
				bs.Write(true);
				bs.Write(o.BuyMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SellMessage != null)
			{
				bs.Write(true);
				bs.Write(o.SellMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SaleDescription != null)
			{
				bs.Write(true);
				bs.Write(o.SaleDescription);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
