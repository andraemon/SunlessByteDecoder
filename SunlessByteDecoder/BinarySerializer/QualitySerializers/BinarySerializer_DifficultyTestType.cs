using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_DifficultyTestType
    {
        public static DifficultyTestType Deserialize(BinaryReader bs)
        {
            return (DifficultyTestType)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, DifficultyTestType o)
        {
            bs.Write((int)o);
        }
    }
}
