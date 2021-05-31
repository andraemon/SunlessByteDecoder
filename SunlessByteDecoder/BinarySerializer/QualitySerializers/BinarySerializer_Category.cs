using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_Category
    {
        public static Category Deserialize(BinaryReader bs)
        {
            return (Category)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, Category o)
        {
            bs.Write((int)o);
        }
    }
}
