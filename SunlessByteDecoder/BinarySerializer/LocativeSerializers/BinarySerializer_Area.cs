using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using System.Linq;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Area
    {
        public static Area Deserialize(BinaryReader bs)
        {
            Area area = new Area();
            if (!bs.ReadBoolean())
            {
                return null;
            }
            if (bs.ReadBoolean())
            {
                area.Description = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                area.ImageName = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                area.World = BinarySerializer_World.Deserialize(bs);
            }
            area.MarketAccessPermitted = bs.ReadBoolean();
            if (bs.ReadBoolean())
            {
                area.MoveMessage = bs.ReadString();
            }
            area.HideName = bs.ReadBoolean();
            area.RandomPostcard = bs.ReadBoolean();
            area.MapX = bs.ReadInt32();
            area.MapY = bs.ReadInt32();
            if (bs.ReadBoolean())
            {
                area.UnlocksWithQuality = BinarySerializer_Quality.Deserialize(bs);
            }
            area.ShowOps = bs.ReadBoolean();
            area.PremiumSubRequired = bs.ReadBoolean();
            if (bs.ReadBoolean())
            {
                area.Name = bs.ReadString();
            }
            area.Id = bs.ReadInt32();
            return area;
        }

        public static List<Area> DeserializeCollection(BinaryReader bs)
        {
            List<Area> list = new List<Area>();
            int num = bs.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                list.Add(Deserialize(bs));
            }
            return list;
        }

		public static void Serialize(BinaryWriter bs, Area o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
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
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.MarketAccessPermitted);
			if (o.MoveMessage != null)
			{
				bs.Write(true);
				bs.Write(o.MoveMessage);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.HideName);
			bs.Write(o.RandomPostcard);
			bs.Write(o.MapX);
			bs.Write(o.MapY);
			if (o.UnlocksWithQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.UnlocksWithQuality);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.ShowOps);
			bs.Write(o.PremiumSubRequired);
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

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Area> c)
		{
			bs.Write(c.Count());
			foreach (Area o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
