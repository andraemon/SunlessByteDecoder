using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_PrivilegeLevel
    {
        internal static PrivilegeLevel Deserialize(BinaryReader bs)
        {
            return (PrivilegeLevel)bs.ReadInt32();
        }
    }
}
