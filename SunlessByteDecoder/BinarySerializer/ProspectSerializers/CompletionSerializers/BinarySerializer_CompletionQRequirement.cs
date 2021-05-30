using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers.CompletionSerializers
{
    public class BinarySerializer_CompletionQRequirement
    {
        internal static CompletionQRequirement Deserialize(BinaryReader bs)
		{
			CompletionQRequirement completionQRequirement = new CompletionQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				completionQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				completionQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				completionQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completionQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completionQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			completionQRequirement.Id = bs.ReadInt32();
			return completionQRequirement;
		}
	}
}
