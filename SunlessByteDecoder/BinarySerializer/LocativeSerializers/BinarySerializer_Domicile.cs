using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Domicile
    {
        internal static Domicile Deserialize(BinaryReader bs)
        {
			Domicile domicile = new Domicile();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				domicile.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				domicile.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				domicile.ImageName = bs.ReadString();
			}
			domicile.MaxHandSize = bs.ReadInt32();
			domicile.DefenceBonus = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				domicile.World = BinarySerializer_World.Deserialize(bs);
			}
			domicile.Id = bs.ReadInt32();
			return domicile;
		}

		internal static List<Domicile> DeserializeCollection(BinaryReader bs)
{
			List<Domicile> list = new List<Domicile>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}
	}
}
