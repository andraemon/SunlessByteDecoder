using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_RelationshipDirection
    {
        internal static RelationshipDirection Deserialize(BinaryReader bs)
        {
            return (RelationshipDirection)bs.ReadInt32();
        }
    }
}
