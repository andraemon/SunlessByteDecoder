using SunlessByteDecoder.GameClasses.MetaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.MetaSerializers
{
    public class BinarySerializer_PublishState
    {
        internal static PublishState Deserialize(BinaryReader bs)
        {
            return (PublishState)bs.ReadInt32();
        }
    }
}
