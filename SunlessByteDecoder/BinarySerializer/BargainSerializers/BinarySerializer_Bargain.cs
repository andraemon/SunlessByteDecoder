using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.BargainClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace SunlessByteDecoder.BinarySerializer.BargainSerializers
{
    public class BinarySerializer_Bargain
    {
		public static Bargain Deserialize(BinaryReader bs)
		{
			Bargain bargain = new Bargain();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				bargain.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				bargain.Tags = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.Offer = BinarySerializer_Quality.Deserialize(bs);
			}
			bargain.Stock = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				bargain.Price = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.QualitiesRequired = new List<BargainQRequirement>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					bargain.QualitiesRequired.Add(BinarySerializer_BargainQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				bargain.Teaser = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				bargain.Name = bs.ReadString();
			}
			bargain.Id = bs.ReadInt32();
			return bargain;
		}

		public static List<Bargain> DeserializeCollection(BinaryReader bs)
		{
			List<Bargain> list = new List<Bargain>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Bargain o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Tags != null)
			{
				bs.Write(true);
				bs.Write(o.Tags);
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
			if (o.Offer != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.Offer);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Stock);
			if (o.Price != null)
			{
				bs.Write(true);
				bs.Write(o.Price);
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesRequired != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesRequired.Count);
				foreach (BargainQRequirement o2 in o.QualitiesRequired)
				{
					BinarySerializer_BargainQRequirement.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.Teaser != null)
			{
				bs.Write(true);
				bs.Write(o.Teaser);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Bargain> c)
		{
			bs.Write(c.Count());
			foreach (Bargain o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
