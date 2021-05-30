using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_Category
    {
        internal static Category Deserialize(BinaryReader bs)
        {
            return (Category)bs.ReadInt32();
        }
    }
}
