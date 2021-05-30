using SunlessByteDecoder.BinarySerializer.LocativeSerializers;
using SunlessByteDecoder.GameClasses.EventClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.EventSerializers
{
    public class BinarySerializer_Deck
    {
		internal static Deck Deserialize(BinaryReader bs)
		{
			Deck deck = new Deck();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			if (bs.ReadBoolean())
			{
				deck.World = BinarySerializer_World.Deserialize(bs);
			}
			if (bs.ReadBoolean())
			{
				deck.Name = bs.ReadString();
			}
			if (bs.ReadBoolean())
			{
				deck.ImageName = bs.ReadString();
			}
			deck.Ordering = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				deck.Description = bs.ReadString();
			}
			deck.Availability = BinarySerializer_Frequency.Deserialize(bs);
			deck.DrawSize = bs.ReadInt32();
			deck.MaxCards = bs.ReadInt32();
			deck.Id = bs.ReadInt32();
			return deck;
		}
	}
}
