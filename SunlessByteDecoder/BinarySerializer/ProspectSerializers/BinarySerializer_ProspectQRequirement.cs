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
		public static ProspectQRequirement Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, ProspectQRequirement o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.Prospect != null)
			{
				bs.Write(true);
				BinarySerializer_Prospect.Serialize(bs, o.Prospect);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CustomLockedMessage != null)
			{
				bs.Write(true);
				bs.Write(o.CustomLockedMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CustomUnlockedMessage != null)
			{
				bs.Write(true);
				bs.Write(o.CustomUnlockedMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MinLevel != null)
			{
				bs.Write(true);
				bs.Write(o.MinLevel.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MaxLevel != null)
			{
				bs.Write(true);
				bs.Write(o.MaxLevel.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MinAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.MinAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.MaxAdvanced != null)
			{
				bs.Write(true);
				bs.Write(o.MaxAdvanced);
			}
			else
			{
				bs.Write(false);
			}
			if (o.AssociatedQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.AssociatedQuality);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
