using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_Nature
    {
        internal static Nature Deserialize(BinaryReader bs)
        {
            return (Nature)bs.ReadInt32();
        }
    }
}
