using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_QualityAllowedOn
    {
        public static QualityAllowedOn Deserialize(BinaryReader bs)
        {
            return (QualityAllowedOn)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, QualityAllowedOn o)
        {
            bs.Write((int)o);
        }
    }
}
