using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_InteractionType
    {
        internal static InteractionType Deserialize(BinaryReader bs)
        {
            return (InteractionType)bs.ReadInt32();
        }
    }
}
