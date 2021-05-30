using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers.ShopSerializers
{
    public class BinarySerializer_ShopQRequirement
    {
		internal static ShopQRequirement Deserialize(BinaryReader bs)
		{
			ShopQRequirement shopQRequirement = new ShopQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				shopQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				shopQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				shopQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				shopQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				shopQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			shopQRequirement.Id = bs.ReadInt32();
			return shopQRequirement;
		}
	}
}
