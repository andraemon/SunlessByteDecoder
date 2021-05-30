using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ProspectClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers
{
    public class BinarySerializer_ProspectQRequirement
    {
		internal static ProspectQRequirement Deserialize(BinaryReader bs)
		{
			ProspectQRequirement prospectQRequirement = new ProspectQRequirement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.Prospect = BinarySerializer_Prospect.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.CustomLockedMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.CustomUnlockedMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.MinLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.MaxLevel = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.MinAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.MaxAdvanced = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospectQRequirement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			prospectQRequirement.Id = bs.ReadInt32();
			return prospectQRequirement;
		}
	}
}
