using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_Frequency
    {
        internal static Frequency Deserialize(BinaryReader bs)
        {
            return (Frequency)bs.ReadInt32();
        }
    }
}
