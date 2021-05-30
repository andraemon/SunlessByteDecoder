using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_Urgency
    {
        internal static Urgency Deserialize(BinaryReader bs)
        {
            return (Urgency)bs.ReadInt32();
        }
    }
}
