using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_InvitationRestriction
    {
        internal static InvitationRestriction Deserialize(BinaryReader bs)
        {
            return (InvitationRestriction)bs.ReadInt32();
        }
    }
}
