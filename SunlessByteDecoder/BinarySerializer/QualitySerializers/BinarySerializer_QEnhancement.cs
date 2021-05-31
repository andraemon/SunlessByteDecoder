using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_QEnhancement
    {
		public static QEnhancement Deserialize(BinaryReader bs)
		{
			QEnhancement qenhancement = new QEnhancement();
			if (!bs.ReadBoolean())
			{
				return null;
			}
			qenhancement.Level = bs.ReadInt32();
			if (bs.ReadBoolean())
			{
				qenhancement.AssociatedQuality = BinarySerializer_Quality.Deserialize(bs);
			}
			qenhancement.Id = bs.ReadInt32();
			return qenhancement;
		}

		public static void Serialize(BinaryWriter bs, QEnhancement o)
		{
			if (o == null)
			{
				bs.Write(false);
				return;
			}
			bs.Write(true);
			bs.Write(o.Level);
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
