using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_UserStatus
    {
        public static UserStatus Deserialize(BinaryReader bs)
        {
            return (UserStatus)bs.ReadInt32();
        }

        public static void Serialize(BinaryWriter bs, UserStatus o)
        {
            bs.Write((int)o);
        }
    }
}
