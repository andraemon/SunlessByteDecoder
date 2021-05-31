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
        public static CompletionQRequirement Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, CompletionQRequirement o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
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
