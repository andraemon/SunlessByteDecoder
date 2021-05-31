using SunlessByteDecoder.GameClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.ActClasses
{
    public class ActQEffectOnVictor : BaseQEffect
    {
		public ActQEffectOnVictor()
		{
			Mirroring = false;
		}
		public virtual bool Mirroring { get; set; }
	}
}
