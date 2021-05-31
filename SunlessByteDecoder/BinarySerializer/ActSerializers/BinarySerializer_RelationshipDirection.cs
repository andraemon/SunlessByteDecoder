using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_RelationshipDirection
    {
        public static RelationshipDirection Deserialize(BinaryReader bs)
        {
            return (RelationshipDirection)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, RelationshipDirection o)
        {
            bs.Write((int)o);
        }
    }
}
