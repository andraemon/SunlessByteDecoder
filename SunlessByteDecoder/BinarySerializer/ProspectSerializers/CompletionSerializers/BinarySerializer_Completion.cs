using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers.CompletionSerializers
{
    public class BinarySerializer_Completion
    {
        internal static Completion Deserialize(BinaryReader bs)
		{
			Completion completion = new Completion();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				completion.Prospect = BinarySerializer_Prospect.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				completion.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completion.SatisfactionMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				completion.QualitiesAffected = new List<CompletionQEffect>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					completion.QualitiesAffected.Add(BinarySerializer_CompletionQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				completion.QualitiesRequired = new List<CompletionQRequirement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					completion.QualitiesRequired.Add(BinarySerializer_CompletionQRequirement.Deserialize(bs));
				}
			}
			completion.Id = bs.ReadInt32();
			return completion;
		}
	}
}
