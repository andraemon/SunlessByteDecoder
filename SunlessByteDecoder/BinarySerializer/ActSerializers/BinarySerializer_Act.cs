using SunlessByteDecoder.BinarySerializer.EventSerializers;
using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.BinarySerializer.QualitySerializers;
using SunlessByteDecoder.GameClasses.ActClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.ActSerializers
{
    public class BinarySerializer_Act
    {
		public static Act Deserialize(BinaryReader bs)
		{
			Act act = new Act();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				act.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.ImageName = bs.ReadString();
			}
			act.InteractionType = BinarySerializer_InteractionType.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				act.Tag = bs.ReadString();
			}
			act.Urgency = BinarySerializer_ActUrgency.Deserialize(bs);
			act.InvitationDomain = BinarySerializer_InvitationDomain.Deserialize(bs);
			act.InvitationRestriction = BinarySerializer_InvitationRestriction.Deserialize(bs);
			if (bs.ReadBoolean())
			{
				act.InviteMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.TwitterInviteMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.AcceptMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.CooperativeCompletionMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.WinMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.LoseMessage = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.InviterModifier = bs.ReadString();
			}
			act.IsUnique = bs.ReadBoolean();
			if (bs.ReadBoolean())
			{
				act.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				act.Cooldown = new int?(bs.ReadInt32());
			}
			if (bs.ReadBoolean())
			{
				act.SocialEvent = BinarySerializer_Event.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				act.ChallengeOn = BinarySerializer_Quality.Deserialize(bs);
			}
			act.ParticipantsRequired = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				act.QualitiesAffectedOnTarget = new List<ActQEffect>();
				int num = bs.ReadInt32();
				for (int i = 0; i < num; i++)
				{
					act.QualitiesAffectedOnTarget.Add(BinarySerializer_ActQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				act.QualitiesAffectedOnVictor = new List<ActQEffectOnVictor>();
				int num2 = bs.ReadInt32();
				for (int j = 0; j < num2; j++)
				{
					act.QualitiesAffectedOnVictor.Add(BinarySerializer_ActQEffectOnVictor.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				act.QualitiesRequired = new List<ActQRequirement>();
				int num3 = bs.ReadInt32();
				for (int k = 0; k < num3; k++)
				{
					act.QualitiesRequired.Add(BinarySerializer_ActQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				act.QualitiesRequiredOnInviter = new List<ActInviterQRequirement>();
				int num4 = bs.ReadInt32();
				for (int l = 0; l < num4; l++)
				{
					act.QualitiesRequiredOnInviter.Add(BinarySerializer_ActInviterQRequirement.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				act.QualitiesAffectedOnInviterOnRejection = new List<ActOnRejectQEffect>();
				int num5 = bs.ReadInt32();
				for (int m = 0; m < num5; m++)
				{
					act.QualitiesAffectedOnInviterOnRejection.Add(BinarySerializer_ActOnRejectQEffect.Deserialize(bs));
				}
			}
			if (bs.ReadBoolean())
			{
				act.SSAbilityType = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.SSAbilityAnimation = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				act.World = BinarySerializer_World.Deserialize(bs);
			}
			act.Id = bs.ReadInt32();
			return act;
		}

		public static void Serialize(BinaryWriter bs, Act o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ImageName != null)
			{
				bs.Write(true);
				bs.Write(o.ImageName);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_InteractionType.Serialize(bs, o.InteractionType);
			if (o.Tag != null)
			{
				bs.Write(true);
				bs.Write(o.Tag);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_ActUrgency.Serialize(bs, o.Urgency);
			BinarySerializer_InvitationDomain.Serialize(bs, o.InvitationDomain);
			BinarySerializer_InvitationRestriction.Serialize(bs, o.InvitationRestriction);
			if (o.InviteMessage != null)
			{
				bs.Write(true);
				bs.Write(o.InviteMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterInviteMessage != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterInviteMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.AcceptMessage != null)
			{
				bs.Write(true);
				bs.Write(o.AcceptMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CooperativeCompletionMessage != null)
			{
				bs.Write(true);
				bs.Write(o.CooperativeCompletionMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.WinMessage != null)
			{
				bs.Write(true);
				bs.Write(o.WinMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LoseMessage != null)
			{
				bs.Write(true);
				bs.Write(o.LoseMessage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.InviterModifier != null)
			{
				bs.Write(true);
				bs.Write(o.InviterModifier);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.IsUnique);
			if (o.AssociatedQuality != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.AssociatedQuality);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Cooldown != null)
			{
				bs.Write(true);
				bs.Write(o.Cooldown.Value);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SocialEvent != null)
			{
				bs.Write(true);
				BinarySerializer_Event.Serialize(bs, o.SocialEvent);
			}
			else
			{
				bs.Write(false);
			}
			if (o.ChallengeOn != null)
			{
				bs.Write(true);
				BinarySerializer_Quality.Serialize(bs, o.ChallengeOn);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.ParticipantsRequired);
			if (o.QualitiesAffectedOnTarget != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffectedOnTarget.Count);
				foreach (ActQEffect o2 in o.QualitiesAffectedOnTarget)
				{
					BinarySerializer_ActQEffect.Serialize(bs, o2);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesAffectedOnVictor != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffectedOnVictor.Count);
				foreach (ActQEffectOnVictor o3 in o.QualitiesAffectedOnVictor)
				{
					BinarySerializer_ActQEffectOnVictor.Serialize(bs, o3);
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
				foreach (ActQRequirement o4 in o.QualitiesRequired)
				{
					BinarySerializer_ActQRequirement.Serialize(bs, o4);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesRequiredOnInviter != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesRequiredOnInviter.Count);
				foreach (ActInviterQRequirement o5 in o.QualitiesRequiredOnInviter)
				{
					BinarySerializer_ActInviterQRequirement.Serialize(bs, o5);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.QualitiesAffectedOnInviterOnRejection != null)
			{
				bs.Write(true);
				bs.Write(o.QualitiesAffectedOnInviterOnRejection.Count);
				foreach (ActOnRejectQEffect o6 in o.QualitiesAffectedOnInviterOnRejection)
				{
					BinarySerializer_ActOnRejectQEffect.Serialize(bs, o6);
				}
			}
			else
			{
				bs.Write(false);
			}
			if (o.SSAbilityType != null)
			{
				bs.Write(true);
				bs.Write(o.SSAbilityType);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SSAbilityAnimation != null)
			{
				bs.Write(true);
				bs.Write(o.SSAbilityAnimation);
			}
			else
			{
				bs.Write(false);
			}
			if (o.World != null)
			{
				bs.Write(true);
				BinarySerializer_World.Serialize(bs, o.World);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Id);
		}
	}
}
