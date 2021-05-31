using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_Genre
    {
        public static Genre Deserialize(BinaryReader bs)
        {
            return (Genre)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, Genre o)
        {
            bs.Write((int)o);
        }
    }
}
