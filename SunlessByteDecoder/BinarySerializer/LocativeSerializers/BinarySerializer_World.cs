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
        internal static World Deserialize(BinaryReader bs)
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
    }
}
