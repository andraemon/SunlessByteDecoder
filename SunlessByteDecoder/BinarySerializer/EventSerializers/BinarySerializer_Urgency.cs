using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_Urgency
    {
        public static Urgency Deserialize(BinaryReader bs)
        {
            return (Urgency)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, Urgency o)
        {
            bs.Write((int)o);
        }
    }
}
