using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using SunlessByteDecoder.GameClasses.LocativeClasses;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Domicile
    {
        public static Domicile Deserialize(BinaryReader bs)
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

		public static List<Domicile> DeserializeCollection(BinaryReader bs)
{
			List<Domicile> list = new List<Domicile>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Domicile o)
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
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ImageName != null)
			{
				bs.Write(true);
				bs.Write(o.ImageName);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.MaxHandSize);
			bs.Write(o.DefenceBonus);
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Domicile> c)
		{
			bs.Write(c.Count());
			foreach (Domicile o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
