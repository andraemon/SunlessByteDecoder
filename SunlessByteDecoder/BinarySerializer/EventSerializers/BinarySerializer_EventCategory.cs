using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_EventCategory
    {
        public static EventCategory Deserialize(BinaryReader bs)
        {
            return (EventCategory)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, EventCategory o)
        {
            bs.Write((int)o);
        }
    }
}
