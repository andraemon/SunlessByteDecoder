using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.QualityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.LocativeClasses.ShopClasses
{
    internal class Availability : Entity
    {
		public virtual Quality Quality { get; set; }
		public virtual int Cost { get; set; }
		public virtual int SellPrice { get; set; }
		public virtual Shop InShop { get; set; }
		public virtual Quality PurchaseQuality { get; set; }
		public virtual string BuyMessage { get; set; }
		public virtual string SellMessage { get; set; }
		public virtual string SaleDescription { get; set; }
	}
}
