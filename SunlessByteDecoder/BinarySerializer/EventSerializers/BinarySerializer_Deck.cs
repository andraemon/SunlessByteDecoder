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
		public static Deck Deserialize(BinaryReader bs)
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

		public static void Serialize(BinaryWriter bs, Deck o)
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
			bs.Write(o.Ordering);
			if (o.Description != null)
			{
				bs.Write(true);
				bs.Write(o.Description);
			}
			else
			{
				bs.Write(false);
			}
			BinarySerializer_Frequency.Serialize(bs, o.Availability);
			bs.Write(o.DrawSize);
			bs.Write(o.MaxCards);
			bs.Write(o.Id);
		}
	}
}
