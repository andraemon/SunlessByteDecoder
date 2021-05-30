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
		internal static Availability Deserialize(BinaryReader bs)
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
	}
}
