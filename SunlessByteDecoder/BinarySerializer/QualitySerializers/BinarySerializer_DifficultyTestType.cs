using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_DifficultyTestType
    {
        internal static DifficultyTestType Deserialize(BinaryReader bs)
        {
            return (DifficultyTestType)bs.ReadInt32();
        }
    }
}
