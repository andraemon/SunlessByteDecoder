using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using SunlessByteDecoder.BinarySerializer.GeneralSerializers;
using SunlessByteDecoder.BinarySerializer.MetaSerializers;

namespace SunlessByteDecoder.BinarySerializer.LocativeSerializers
{
    public class BinarySerializer_World
    {
        public static World Deserialize(BinaryReader bs)
        {
            World world = new World();
            if (!bs.ReadBoolean())
            {
                return null;
            }
            world.GeneralQualityCatalogue = bs.ReadBoolean();
            world.ShowCardTitles = bs.ReadBoolean();
            if (bs.ReadBoolean())
            {
                world.CharacterCreationPageText = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.EndPageText = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.FrontPageText = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.CustomCss = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.Credits = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.Description = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.Name = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.Domain = bs.ReadString();
            }
            world.Promoted = bs.ReadInt32();
            if (bs.ReadBoolean())
            {
                world.DefaultSetting = BinarySerializer_Setting.Deserialize(bs);
            }
            world.FacebookAuth = bs.ReadBoolean();
            world.TwitterAuth = bs.ReadBoolean();
            world.EmailAuth = bs.ReadBoolean();
            if (bs.ReadBoolean())
            {
                world.FacebookAPIKey = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.FacebookAppId = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.FacebookAppSecret = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.GameUserTwitterAuthToken = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.GameUserTwitterAuthTokenSecret = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.TwitterConsumerKey = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.TwitterConsumerSecret = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.TwitterCallbackUrl = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.AmazonHostedImageUrl = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.AmazonBucketName = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.StyleSheet = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.LogoImage = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.DefaultStartingSetting = BinarySerializer_Setting.Deserialize(bs);
            }
            if (bs.ReadBoolean())
            {
                world.Owner = BinarySerializer_User.Deserialize(bs);
            }
            world.IsPortalWorld = bs.ReadBoolean();
            world.Monetizes = bs.ReadBoolean();
            if (bs.ReadBoolean())
            {
                world.PaymentEmailAddress = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.SupportEmailAddress = bs.ReadString();
            }
            if (bs.ReadBoolean())
            {
                world.SystemFromEmailAddress = bs.ReadString();
            }
            world.LastUpdated = BinarySerializer_DateTime.Deserialize(bs);
            if (bs.ReadBoolean())
            {
                world.UpdateNotes = bs.ReadString();
            }
            world.PublishState = BinarySerializer_PublishState.Deserialize(bs);
            world.Genre = BinarySerializer_Genre.Deserialize(bs);
            world.Id = bs.ReadInt32();
            return world;
        }

		public static void Serialize(BinaryWriter bs, World o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			bs.Write(o.GeneralQualityCatalogue);
			bs.Write(o.ShowCardTitles);
			if (o.CharacterCreationPageText != null)
			{
				bs.Write(true);
				bs.Write(o.CharacterCreationPageText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.EndPageText != null)
			{
				bs.Write(true);
				bs.Write(o.EndPageText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FrontPageText != null)
			{
				bs.Write(true);
				bs.Write(o.FrontPageText);
			}
			else
			{
				bs.Write(false);
			}
			if (o.CustomCss != null)
			{
				bs.Write(true);
				bs.Write(o.CustomCss);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Credits != null)
			{
				bs.Write(true);
				bs.Write(o.Credits);
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
			if (o.Name != null)
			{
				bs.Write(true);
				bs.Write(o.Name);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Domain != null)
			{
				bs.Write(true);
				bs.Write(o.Domain);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.Promoted);
			if (o.DefaultSetting != null)
			{
				bs.Write(true);
				BinarySerializer_Setting.Serialize(bs, o.DefaultSetting);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.FacebookAuth);
			bs.Write(o.TwitterAuth);
			bs.Write(o.EmailAuth);
			if (o.FacebookAPIKey != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookAPIKey);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FacebookAppId != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookAppId);
			}
			else
			{
				bs.Write(false);
			}
			if (o.FacebookAppSecret != null)
			{
				bs.Write(true);
				bs.Write(o.FacebookAppSecret);
			}
			else
			{
				bs.Write(false);
			}
			if (o.GameUserTwitterAuthToken != null)
			{
				bs.Write(true);
				bs.Write(o.GameUserTwitterAuthToken);
			}
			else
			{
				bs.Write(false);
			}
			if (o.GameUserTwitterAuthTokenSecret != null)
			{
				bs.Write(true);
				bs.Write(o.GameUserTwitterAuthTokenSecret);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterConsumerKey != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterConsumerKey);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterConsumerSecret != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterConsumerSecret);
			}
			else
			{
				bs.Write(false);
			}
			if (o.TwitterCallbackUrl != null)
			{
				bs.Write(true);
				bs.Write(o.TwitterCallbackUrl);
			}
			else
			{
				bs.Write(false);
			}
			if (o.AmazonHostedImageUrl != null)
			{
				bs.Write(true);
				bs.Write(o.AmazonHostedImageUrl);
			}
			else
			{
				bs.Write(false);
			}
			if (o.AmazonBucketName != null)
			{
				bs.Write(true);
				bs.Write(o.AmazonBucketName);
			}
			else
			{
				bs.Write(false);
			}
			if (o.StyleSheet != null)
			{
				bs.Write(true);
				bs.Write(o.StyleSheet);
			}
			else
			{
				bs.Write(false);
			}
			if (o.LogoImage != null)
			{
				bs.Write(true);
				bs.Write(o.LogoImage);
			}
			else
			{
				bs.Write(false);
			}
			if (o.DefaultStartingSetting != null)
			{
				bs.Write(true);
				BinarySerializer_Setting.Serialize(bs, o.DefaultStartingSetting);
			}
			else
			{
				bs.Write(false);
			}
			if (o.Owner != null)
			{
				bs.Write(true);
				BinarySerializer_User.Serialize(bs, o.Owner);
			}
			else
			{
				bs.Write(false);
			}
			bs.Write(o.IsPortalWorld);
			bs.Write(o.Monetizes);
			if (o.PaymentEmailAddress != null)
			{
				bs.Write(true);
				bs.Write(o.PaymentEmailAddress);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SupportEmailAddress != null)
			{
				bs.Write(true);
				bs.Write(o.SupportEmailAddress);
			}
			else
			{
				bs.Write(false);
			}
			if (o.SystemFromEmailAddress != null)
			{
				bs.Write(true);
				bs.Write(o.SystemFromEmailAddress);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_DateTime.Serialize(bs, o.LastUpdated);
			if (o.UpdateNotes != null)
			{
				bs.Write(true);
				bs.Write(o.UpdateNotes);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_PublishState.Serialize(bs, o.PublishState);
			BinarySerializer_Genre.Serialize(bs, o.Genre);
			bs.Write(o.Id);
		}
	}
}
