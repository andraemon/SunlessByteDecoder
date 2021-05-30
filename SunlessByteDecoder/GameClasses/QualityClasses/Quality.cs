using SunlessByteDecoder.GameClasses.BaseClasses;
using SunlessByteDecoder.GameClasses.EventClasses;
using SunlessByteDecoder.GameClasses.LocativeClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunlessByteDecoder.GameClasses.QualityClasses
{
    internal class Quality : EntityWithName
    {
        public Quality()
        {
            PyramidNumberIncreaseLimit = 50;
            Name = string.Empty;
            Visible = true;
            Description = string.Empty;
            OwnerName = string.Empty;
            AllowedOn = QualityAllowedOn.Unspecified;
            Nature = Nature.Unspecified;
            QualitiesPossessedList = new List<AspectQPossession>();
            Enhancements = new List<QEnhancement>();
            DifficultyScaler = 60;
            RelationshipCapable = false;
            QEffectPriority = 2;
            if (Tag == null)
            {
                Tag = string.Empty;
            }
        }
        public virtual IList<AspectQPossession> QualitiesPossessedList { get; set; }
        public virtual bool RelationshipCapable { get; set; }
        public virtual string PluralName { get; set; }
        public virtual string OwnerName { get; set; }
        public virtual string Description { get; set; }
        public virtual string Image { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Tag { get; set; }
        public virtual int? Cap { get; set; }
        public virtual string CapAdvanced { get; set; }
        public virtual int HimbleLevel { get; set; }
        public virtual bool UsePyramidNumbers { get; set; }
        public virtual int PyramidNumberIncreaseLimit { get; set; }
        public virtual string AvailableAt { get; set; }
        public virtual bool PreventNaming { get; set; }
        public virtual string CssClasses { get; set; }
        public virtual int QEffectPriority { get; set; }
        public virtual int? QEffectMinimalLimit { get; set; }
        public virtual World World { get; set; }
        public virtual int Ordering { get; set; }
        public virtual bool IsSlot { get; set; }
        public virtual Area LimitedToArea { get; set; }
        public virtual Quality AssignToSlot { get; set; }
        public virtual Quality ParentQuality { get; set; }
        public virtual bool Persistent { get; set; }
        public virtual bool Visible { get; set; }
        public virtual IList<QEnhancement> Enhancements { get; set; }
        public virtual string EnhancementsDescription { get; set; }
        public virtual Quality SecondChanceQuality { get; set; }
        public virtual Event UseEvent { get; set; }
        public virtual DifficultyTestType DifficultyTestType { get; set; }
        public virtual int DifficultyScaler { get; set; }
        public virtual QualityAllowedOn AllowedOn { get; set; }
        public virtual Nature Nature { get; set; }
        public virtual Category Category { get; set; }
        public virtual string LevelDescriptionText { get; set; }
        public virtual string ChangeDescriptionText { get; set; }
        public virtual string DescendingChangeDescriptionText { get; set; }
        public virtual string LevelImageText { get; set; }
        public virtual string VariableDescriptionText { get; set; }
    }
}
