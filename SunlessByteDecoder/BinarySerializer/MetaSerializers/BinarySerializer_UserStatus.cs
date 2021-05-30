using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_UserStatus
    {
        internal static UserStatus Deserialize(BinaryReader bs)
        {
            return (UserStatus)bs.ReadInt32();
        }
    }
}
