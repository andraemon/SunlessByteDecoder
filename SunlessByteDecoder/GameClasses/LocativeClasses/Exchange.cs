using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses
{
	public class Exchange : EntityWithName
	{
		public override string Name { get; set; }
		public virtual string Image { get; set; }
		public virtual string Title { get; set; }
		public virtual string Description { get; set; }
		public virtual IList<Shop> Shops { get; set; }
		public virtual List<int> SettingIds { get; set; }
	}
}
