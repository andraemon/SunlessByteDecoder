using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_LoggedInVia
    {
        internal static LoggedInVia Deserialize(BinaryReader bs)
        {
            return (LoggedInVia)bs.ReadInt32();
        }
    }
}
