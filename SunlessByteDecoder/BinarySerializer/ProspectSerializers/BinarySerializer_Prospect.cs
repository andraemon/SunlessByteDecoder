using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.ProspectSerializers.CompletionSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ProspectClasses;
using SunlessByteDecoder.GameClasses.ProspectClasses.CompletionClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace SunlessByteDecoder.BinarySerializer.ProspectSerializers
{
    public class BinarySerializer_Prospect
    {
		public static Prospect Deserialize(BinaryReader bs)
		{
			Prospect prospect = new Prospect();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				prospect.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				prospect.Tags = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospect.Description = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospect.Setting = BinarySerializer_Setting.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				prospect.Request = BinarySerializer_Quality.Deserialize(bs);
			}
			prospect.Demand = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				prospect.Payment = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				prospect.QualitiesAffected = new List<ProspectQEffect>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					prospect.QualitiesAffected.Add(BinarySerializer_ProspectQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				prospect.QualitiesRequired = new List<ProspectQRequirement>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					prospect.QualitiesRequired.Add(BinarySerializer_ProspectQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				prospect.Completions = new List<Completion>();
				int num3 = bs.ReadInt32();
				for (int k = 0; k < num3; k++)
				{
					prospect.Completions.Add(BinarySerializer_Completion.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				prospect.Name = bs.ReadString();
			}
			prospect.Id = bs.ReadInt32();
			return prospect;
		}

		public static List<Prospect> DeserializeCollection(BinaryReader bs)
		{
			List<Prospect> list = new List<Prospect>();
			int num = bs.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(Deserialize(bs));
			}
			return list;
		}

		public static void Serialize(BinaryWriter bs, Prospect o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Tags != null)
			{
				bs.Write(true);
				bs.Write(o.Tags);
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
			if (o.Setting != null)
			{
				bs.Write(true);
				BinarySerializer_Setting.Serialize(bs, o.Setting);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Request != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.Request);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Demand);
			if (o.Payment != null)
			{
				bs.Write(true);
				bs.Write(o.Payment);
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesAffected != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffected.Count);
				foreach (ProspectQEffect o2 in o.QualitiesAffected)
				{
					BinarySerializer_ProspectQEffect.Serialize(bs, o2);
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
				foreach (ProspectQRequirement o3 in o.QualitiesRequired)
				{
					BinarySerializer_ProspectQRequirement.Serialize(bs, o3);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.Completions != null)
			{
				bs.Write(true);
				bs.Write(o.Completions.Count);
				foreach (Completion o4 in o.Completions)
				{
					BinarySerializer_Completion.Serialize(bs, o4);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}

		public static void SerializeCollection(BinaryWriter bs, IEnumerable<Prospect> c)
		{
			bs.Write(c.Count());
			foreach (Prospect o in c)
			{
				Serialize(bs, o);
			}
		}
	}
}
