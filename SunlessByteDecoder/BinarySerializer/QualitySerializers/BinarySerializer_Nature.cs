using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_Nature
    {
        public static Nature Deserialize(BinaryReader bs)
        {
            return (Nature)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, Nature o)
        {
            bs.Write((int)o);
        }
    }
}
