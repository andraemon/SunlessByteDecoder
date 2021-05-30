﻿using SunlessByteDecoder.BinarySerializer.EventSerializers;
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
		internal static Act Deserialize(BinaryReader bs)
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
	}
}
