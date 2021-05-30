using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_ActUrgency
    {
        internal static ActUrgency Deserialize(BinaryReader bs)
        {
            return (ActUrgency)bs.ReadInt32();
        }
    }
}
