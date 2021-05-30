using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_InvitationDomain
    {
        internal static InvitationDomain Deserialize(BinaryReader bs)
        {
            return (InvitationDomain)bs.ReadInt32();
        }
    }
}
