using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SunlessByteDecoder.BinarySerializer.QualitySerializers
{
    public class BinarySerializer_QEnhancement
    {
		internal static QEnhancement Deserialize(BinaryReader bs)
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
	}
}
