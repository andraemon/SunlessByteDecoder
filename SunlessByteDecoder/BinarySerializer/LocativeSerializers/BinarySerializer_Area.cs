using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_Area
    {
        internal static Area Deserialize(BinaryReader bs)
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

        internal static List<Area> DeserializeCollection(BinaryReader bs)
        {
            List<Area> list = new List<Area>();
            int num = bs.ReadInt32();
            for (int i = 0; i < num; i++)
            {
                list.Add(Deserialize(bs));
            }
            return list;
        }
    }
}
