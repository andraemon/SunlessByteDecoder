using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_ViaNetwork
    {
        internal static ViaNetwork Deserialize(BinaryReader bs)
        {
            return (ViaNetwork)bs.ReadInt32();
        }
    }
}
