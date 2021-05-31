using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers.CompletionSerializers
{
    public class BinarySerializer_Completion
    {
        public static Completion Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, Completion o)
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
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SatisfactionMessage != null)
			{
				bs.Write(true);
				bs.Write(o.SatisfactionMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesAffected != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffected.Count);
				foreach (CompletionQEffect o2 in o.QualitiesAffected)
				{
					BinarySerializer_CompletionQEffect.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesRequired != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesRequired.Count);
				foreach (CompletionQRequirement o3 in o.QualitiesRequired)
				{
					BinarySerializer_CompletionQRequirement.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
