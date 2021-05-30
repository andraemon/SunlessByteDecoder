using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_EventCategory
    {
        internal static EventCategory Deserialize(BinaryReader bs)
        {
            return (EventCategory)bs.ReadInt32();
        }
    }
}
