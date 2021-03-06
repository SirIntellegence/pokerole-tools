﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Xml;
using System.Diagnostics;
using System.ComponentModel;

namespace Pokerole.Core{
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record Move : BaseDataItem
	{
		public Move(DataId dataId,
			string name,
			string description,
			int power,
			MoveCategory moveCategory,
			ItemReference<ITypeDefinition> type,
			MoveTarget moveTarget,
			bool ranged,
			ItemReference<ISkill> primaryAccuracySkill,
			bool primaryAccuracyIsNegative,
			ItemReference<ISkill> secondaryAccuracySkill,
			int reducedAccuracy,
			ItemReference<ISkill>? damageSkill,
			int damageModifier,
			bool hasSpecialAccuracyMod,
			bool hasSpecialDamageMod,
			string additionalInfo,
			List<string> effects) : base(dataId)
		{
			Name = name;
			Description = description;
			Power = power;
			MoveCategory = moveCategory;
			Type = type;
			MoveTarget = moveTarget;
			Ranged = ranged;
			PrimaryAccuracySkill = primaryAccuracySkill;
			PrimaryAccuracyIsNegative = primaryAccuracyIsNegative;
			SecondaryAccuracySkill = secondaryAccuracySkill;
			ReducedAccuracy = reducedAccuracy;
			DamageSkill = damageSkill;
			DamageModifier = damageModifier;
			HasSpecialAccuracyMod = hasSpecialAccuracyMod;
			HasSpecialDamageMod = hasSpecialDamageMod;
			AdditionalInfo = additionalInfo;
			Effects = new List<string>(effects).AsReadOnly();
		}

		public ItemReference<Move> ItemReference => new ItemReference<Move>(DataId, Name);

		/// <summary>
		/// Name of the move
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Move's description
		/// </summary>
		public string Description { get; }
		/// <summary>
		/// The power of the move
		/// </summary>
		public int Power { get; }
		/// <summary>
		/// Category of the move
		/// </summary>
		public MoveCategory MoveCategory { get; }
		/// <summary>
		/// Move Type
		/// </summary>
		public ItemReference<ITypeDefinition> Type { get; }
		/// <summary>
		/// What this move targets
		/// </summary>
		public MoveTarget MoveTarget { get; }
		/// <summary>
		/// Whether or not this move is ranged
		/// </summary>
		public bool Ranged { get; }
		/// <summary>
		/// Primary skill used for rolling accuracy
		/// </summary>
		public ItemReference<ISkill> PrimaryAccuracySkill { get; }
		/// <summary>
		/// If true, points missing in the primary skill are used for accuracy
		/// </summary>
		public bool PrimaryAccuracyIsNegative { get; }
		/// <summary>
		/// Secondary skill used for rolling accuracy
		/// </summary>
		public ItemReference<ISkill> SecondaryAccuracySkill { get; }
		/// <summary>
		/// How many more successes are needed for this attack to hit
		/// </summary>
		public int ReducedAccuracy { get; }
		/// <summary>
		/// Skill used to roll damage for this move if any
		/// </summary>
		public ItemReference<ISkill>? DamageSkill { get; }
		/// <summary>
		/// How many more dice to add to the damage roll pool
		/// </summary>
		public int DamageModifier { get; }
		/// <summary>
		/// Refer to AdditionalInfo if this is true
		/// </summary>
		public bool HasSpecialAccuracyMod { get; }
		/// <summary>
		/// Refer to AdditionalInfo if this is true
		/// </summary>
		public bool HasSpecialDamageMod { get; }
		/// <summary>
		/// More information about this move that could not be contained in the other variables
		/// </summary>
		public string AdditionalInfo { get; }
		/// <summary>
		/// List of effects this move causes when it hits
		/// </summary>
		public IReadOnlyList<string> Effects { get; }
		[XmlType(nameof(Move), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<Move>
		{
			public Builder()
			{
				Effects = new List<string>(10);
			}
			public Builder(Move move)
			{
				DataId = move.DataId;
				Name = move.Name;
				Description = move.Description;
				Power = move.Power;
				MoveCategory = move.MoveCategory;
				Type = move.Type;
				MoveTarget = move.MoveTarget;
				Ranged = move.Ranged;
				PrimaryAccuracySkill = move.PrimaryAccuracySkill;
				PrimaryAccuracyIsNegative = move.PrimaryAccuracyIsNegative;
				SecondaryAccuracySkill = move.SecondaryAccuracySkill;
				ReducedAccuracy = move.ReducedAccuracy;
				DamageSkill = move.DamageSkill;
				DamageModifier = move.DamageModifier;
				HasSpecialAccuracyMod = move.HasSpecialAccuracyMod;
				HasSpecialDamageMod = move.HasSpecialDamageMod;
				AdditionalInfo = move.AdditionalInfo;
				Effects = new List<string>(move.Effects);
			}

			public ItemReference<Move>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<Move>(DataId.Value, Name);

			/// <summary>
			/// Name of the move
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Name { get; set; }
			/// <summary>
			/// Move's description
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Description { get; set; }
			/// <summary>
			/// The power of the move
			/// </summary>
			[XmlIgnore]
			public int? Power { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Power", IsNullable = false)]
			public int PowerNullableXmlAccessor
			{
				get => Power ?? default;
				set => Power = value;
			}
			/// <summary>
			/// Category of the move
			/// </summary>
			[XmlIgnore]
			public MoveCategory? MoveCategory { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MoveCategory", IsNullable = false)]
			public MoveCategory MoveCategoryNullableXmlAccessor
			{
				get => MoveCategory ?? default;
				set => MoveCategory = value;
			}
			/// <summary>
			/// Move Type
			/// </summary>
			[XmlIgnore]
			public ItemReference<ITypeDefinition>? Type { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Type", IsNullable = false)]
			public ItemReference<ITypeDefinition>.Builder? TypeXmlAccessor
			{
				get => Type is null ? null : new ItemReference<ITypeDefinition>.Builder(Type ?? default);
				set => Type = value?.Build();
			}

			/// <summary>
			/// What this move targets
			/// </summary>
			[XmlIgnore]
			public MoveTarget? MoveTarget { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MoveTarget", IsNullable = false)]
			public MoveTarget MoveTargetNullableXmlAccessor
			{
				get => MoveTarget ?? default;
				set => MoveTarget = value;
			}
			/// <summary>
			/// Whether or not this move is ranged
			/// </summary>
			[XmlIgnore]
			public bool? Ranged { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Ranged", IsNullable = false)]
			public bool RangedNullableXmlAccessor
			{
				get => Ranged ?? default;
				set => Ranged = value;
			}
			/// <summary>
			/// Primary skill used for rolling accuracy
			/// </summary>
			[XmlIgnore]
			public ItemReference<ISkill>? PrimaryAccuracySkill { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("PrimaryAccuracySkill", IsNullable = false)]
			public ItemReference<ISkill>.Builder? PrimaryAccuracySkillXmlAccessor
			{
				get => PrimaryAccuracySkill is null ? null : new ItemReference<ISkill>.Builder(PrimaryAccuracySkill ?? default);
				set => PrimaryAccuracySkill = value?.Build();
			}

			/// <summary>
			/// If true, points missing in the primary skill are used for accuracy
			/// </summary>
			[XmlIgnore]
			public bool? PrimaryAccuracyIsNegative { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("PrimaryAccuracyIsNegative", IsNullable = false)]
			public bool PrimaryAccuracyIsNegativeNullableXmlAccessor
			{
				get => PrimaryAccuracyIsNegative ?? default;
				set => PrimaryAccuracyIsNegative = value;
			}
			/// <summary>
			/// Secondary skill used for rolling accuracy
			/// </summary>
			[XmlIgnore]
			public ItemReference<ISkill>? SecondaryAccuracySkill { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SecondaryAccuracySkill", IsNullable = false)]
			public ItemReference<ISkill>.Builder? SecondaryAccuracySkillXmlAccessor
			{
				get => SecondaryAccuracySkill is null ? null : new ItemReference<ISkill>.Builder(SecondaryAccuracySkill ?? default);
				set => SecondaryAccuracySkill = value?.Build();
			}

			/// <summary>
			/// How many more successes are needed for this attack to hit
			/// </summary>
			[XmlIgnore]
			public int? ReducedAccuracy { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("ReducedAccuracy", IsNullable = false)]
			public int ReducedAccuracyNullableXmlAccessor
			{
				get => ReducedAccuracy ?? default;
				set => ReducedAccuracy = value;
			}
			/// <summary>
			/// Skill used to roll damage for this move if any
			/// </summary>
			[XmlIgnore]
			public ItemReference<ISkill>? DamageSkill { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("DamageSkill", IsNullable = false)]
			public ItemReference<ISkill>.Builder? DamageSkillXmlAccessor
			{
				get => DamageSkill is null ? null : new ItemReference<ISkill>.Builder(DamageSkill ?? default);
				set => DamageSkill = value?.Build();
			}

			/// <summary>
			/// How many more dice to add to the damage roll pool
			/// </summary>
			[XmlIgnore]
			public int? DamageModifier { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("DamageModifier", IsNullable = false)]
			public int DamageModifierNullableXmlAccessor
			{
				get => DamageModifier ?? default;
				set => DamageModifier = value;
			}
			/// <summary>
			/// Refer to AdditionalInfo if this is true
			/// </summary>
			[XmlIgnore]
			public bool? HasSpecialAccuracyMod { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HasSpecialAccuracyMod", IsNullable = false)]
			public bool HasSpecialAccuracyModNullableXmlAccessor
			{
				get => HasSpecialAccuracyMod ?? default;
				set => HasSpecialAccuracyMod = value;
			}
			/// <summary>
			/// Refer to AdditionalInfo if this is true
			/// </summary>
			[XmlIgnore]
			public bool? HasSpecialDamageMod { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HasSpecialDamageMod", IsNullable = false)]
			public bool HasSpecialDamageModNullableXmlAccessor
			{
				get => HasSpecialDamageMod ?? default;
				set => HasSpecialDamageMod = value;
			}
			/// <summary>
			/// More information about this move that could not be contained in the other variables
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? AdditionalInfo { get; set; }
			/// <summary>
			/// List of effects this move causes when it hits
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<string> Effects { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Move"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (Name is null)
					{
						return false;
					}
					if (Description is null)
					{
						return false;
					}
					if (Power is null)
					{
						return false;
					}
					if (MoveCategory is null)
					{
						return false;
					}
					if (Type is null)
					{
						return false;
					}
					if (MoveTarget is null)
					{
						return false;
					}
					if (Ranged is null)
					{
						return false;
					}
					if (PrimaryAccuracySkill is null)
					{
						return false;
					}
					if (PrimaryAccuracyIsNegative is null)
					{
						return false;
					}
					if (SecondaryAccuracySkill is null)
					{
						return false;
					}
					if (ReducedAccuracy is null)
					{
						return false;
					}
					if (DamageModifier is null)
					{
						return false;
					}
					if (HasSpecialAccuracyMod is null)
					{
						return false;
					}
					if (HasSpecialDamageMod is null)
					{
						return false;
					}
					if (AdditionalInfo is null)
					{
						return false;
					}
					if (Effects is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Move"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Move"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Move Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Move(DataId!.Value,
					Name!,
					Description!,
					Power!.Value,
					MoveCategory!.Value,
					Type!.Value,
					MoveTarget!.Value,
					Ranged!.Value,
					PrimaryAccuracySkill!.Value,
					PrimaryAccuracyIsNegative!.Value,
					SecondaryAccuracySkill!.Value,
					ReducedAccuracy!.Value,
					DamageSkill,
					DamageModifier!.Value,
					HasSpecialAccuracyMod!.Value,
					HasSpecialDamageMod!.Value,
					AdditionalInfo!,
					Effects!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record Item : BaseDataItem
	{
		public Item(DataId dataId,
			string name,
			string description) : base(dataId)
		{
			Name = name;
			Description = description;
		}

		public ItemReference<Item> ItemReference => new ItemReference<Item>(DataId, Name);

		/// <summary>
		/// Item Name
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Item Description
		/// </summary>
		public string Description { get; }
		[XmlType(nameof(Item), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<Item>
		{
			public Builder()
			{			}
			public Builder(Item item)
			{
				DataId = item.DataId;
				Name = item.Name;
				Description = item.Description;
			}

			public ItemReference<Item>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<Item>(DataId.Value, Name);

			/// <summary>
			/// Item Name
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Name { get; set; }
			/// <summary>
			/// Item Description
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Description { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Item"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (Name is null)
					{
						return false;
					}
					if (Description is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Item"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Item"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Item Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Item(DataId!.Value,
					Name!,
					Description!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public struct Height
	{
		public Height(string units,
			double value)
		{
			Units = units;
			Value = value;
		}
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Units { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public double Value { get; }
		[XmlType(nameof(Height), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<Height>
		{
			public Builder()
			{			}
			public Builder(Height height)
			{
				Units = height.Units;
				Value = height.Value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlAttribute()]
			public string? Units { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public double? Value { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlAttribute("Value")]
			public double ValueNullableXmlAccessor
			{
				get => Value ?? default;
				set => Value = value;
			}
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Height"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Units is null)
					{
						return false;
					}
					if (Value is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Height"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Height"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Height Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Height(
					Units!,
					Value!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public struct Weight
	{
		public Weight(string units,
			double value)
		{
			Units = units;
			Value = value;
		}
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Units { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public double Value { get; }
		[XmlType(nameof(Weight), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<Weight>
		{
			public Builder()
			{			}
			public Builder(Weight weight)
			{
				Units = weight.Units;
				Value = weight.Value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlAttribute()]
			public string? Units { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public double? Value { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlAttribute("Value")]
			public double ValueNullableXmlAccessor
			{
				get => Value ?? default;
				set => Value = value;
			}
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Weight"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Units is null)
					{
						return false;
					}
					if (Value is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Weight"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Weight"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Weight Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Weight(
					Units!,
					Value!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public record CustomSkillEntry
	{
		public CustomSkillEntry(string skill,
			int value)
		{
			Skill = skill;
			Value = value;
		}
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Skill { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Value { get; }
		[XmlType(nameof(CustomSkillEntry), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<CustomSkillEntry>
		{
			public Builder()
			{			}
			public Builder(CustomSkillEntry customSkillEntry)
			{
				Skill = customSkillEntry.Skill;
				Value = customSkillEntry.Value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlAttribute()]
			public string? Skill { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Value { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlAttribute("Value")]
			public int ValueNullableXmlAccessor
			{
				get => Value ?? default;
				set => Value = value;
			}
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="CustomSkillEntry"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Skill is null)
					{
						return false;
					}
					if (Value is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="CustomSkillEntry"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="CustomSkillEntry"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override CustomSkillEntry Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new CustomSkillEntry(
					Skill!,
					Value!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record ImageRef : BaseDataItem
	{
		public ImageRef(DataId dataId,
			string filename,
			byte[]? data,
			string? filePath) : base(dataId)
		{
			Filename = filename;
			Data = data;
			FilePath = filePath;
		}

		public ItemReference<ImageRef> ItemReference => new ItemReference<ImageRef>(DataId, Filename);

		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Filename { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public byte[]? Data { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string? FilePath { get; }
		[XmlType(nameof(ImageRef), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<ImageRef>
		{
			public Builder()
			{			}
			public Builder(ImageRef imageRef)
			{
				DataId = imageRef.DataId;
				Filename = imageRef.Filename;
				Data = imageRef.Data;
				FilePath = imageRef.FilePath;
			}

			public ItemReference<ImageRef>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<ImageRef>(DataId.Value, Filename);

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Filename { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = true)]
			public byte[]? Data { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = true)]
			public string? FilePath { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="ImageRef"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (Filename is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="ImageRef"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="ImageRef"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override ImageRef Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new ImageRef(DataId!.Value,
					Filename!,
					Data,
					FilePath);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public record MegaEvolutionEntry
	{
		public MegaEvolutionEntry(ItemReference<Item> item,
			ItemReference<DexEntry> targetEvolution)
		{
			Item = item;
			TargetEvolution = targetEvolution;
		}
		/// <summary>
		/// Item the Pokémon must be holding to perform this megaevolution
		/// </summary>
		public ItemReference<Item> Item { get; }
		/// <summary>
		/// DexEntry to use when mega-evolved
		/// </summary>
		public ItemReference<DexEntry> TargetEvolution { get; }
		[XmlType(nameof(MegaEvolutionEntry), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<MegaEvolutionEntry>
		{
			public Builder()
			{			}
			public Builder(MegaEvolutionEntry megaEvolutionEntry)
			{
				Item = megaEvolutionEntry.Item;
				TargetEvolution = megaEvolutionEntry.TargetEvolution;
			}
			/// <summary>
			/// Item the Pokémon must be holding to perform this megaevolution
			/// </summary>
			[XmlIgnore]
			public ItemReference<Item>? Item { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Item", IsNullable = false)]
			public ItemReference<Item>.Builder? ItemXmlAccessor
			{
				get => Item is null ? null : new ItemReference<Item>.Builder(Item ?? default);
				set => Item = value?.Build();
			}

			/// <summary>
			/// DexEntry to use when mega-evolved
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? TargetEvolution { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("TargetEvolution", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? TargetEvolutionXmlAccessor
			{
				get => TargetEvolution is null ? null : new ItemReference<DexEntry>.Builder(TargetEvolution ?? default);
				set => TargetEvolution = value?.Build();
			}

			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="MegaEvolutionEntry"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Item is null)
					{
						return false;
					}
					if (TargetEvolution is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="MegaEvolutionEntry"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="MegaEvolutionEntry"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override MegaEvolutionEntry Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new MegaEvolutionEntry(
					Item!.Value,
					TargetEvolution!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public record MoveEntry
	{
		public MoveEntry(Rank rank,
			ItemReference<Move> move)
		{
			Rank = rank;
			Move = move;
		}
		/// <summary>
		/// Required rank to learn the given move
		/// </summary>
		public Rank Rank { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public ItemReference<Move> Move { get; }
		[XmlType(nameof(MoveEntry), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<MoveEntry>
		{
			public Builder()
			{			}
			public Builder(MoveEntry moveEntry)
			{
				Rank = moveEntry.Rank;
				Move = moveEntry.Move;
			}
			/// <summary>
			/// Required rank to learn the given move
			/// </summary>
			[XmlIgnore]
			public Rank? Rank { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlAttribute("Rank")]
			public Rank RankNullableXmlAccessor
			{
				get => Rank ?? default;
				set => Rank = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public ItemReference<Move>? Move { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Move", IsNullable = false)]
			public ItemReference<Move>.Builder? MoveXmlAccessor
			{
				get => Move is null ? null : new ItemReference<Move>.Builder(Move ?? default);
				set => Move = value?.Build();
			}

			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="MoveEntry"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Rank is null)
					{
						return false;
					}
					if (Move is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="MoveEntry"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="MoveEntry"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override MoveEntry Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new MoveEntry(
					Rank!.Value,
					Move!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public record AbilityEntry
	{
		public AbilityEntry(bool hidden,
			ItemReference<Ability> ability)
		{
			Hidden = hidden;
			Ability = ability;
		}
		/// <summary>
		/// Whether or not this is a hidden ability
		/// </summary>
		public bool Hidden { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public ItemReference<Ability> Ability { get; }
		[XmlType(nameof(AbilityEntry), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<AbilityEntry>
		{
			public Builder()
			{			}
			public Builder(AbilityEntry abilityEntry)
			{
				Hidden = abilityEntry.Hidden;
				Ability = abilityEntry.Ability;
			}
			/// <summary>
			/// Whether or not this is a hidden ability
			/// </summary>
			[XmlIgnore]
			public bool? Hidden { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlAttribute("Hidden")]
			public bool HiddenNullableXmlAccessor
			{
				get => Hidden ?? default;
				set => Hidden = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public ItemReference<Ability>? Ability { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Ability", IsNullable = false)]
			public ItemReference<Ability>.Builder? AbilityXmlAccessor
			{
				get => Ability is null ? null : new ItemReference<Ability>.Builder(Ability ?? default);
				set => Ability = value?.Build();
			}

			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="AbilityEntry"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Hidden is null)
					{
						return false;
					}
					if (Ability is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="AbilityEntry"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="AbilityEntry"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override AbilityEntry Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new AbilityEntry(
					Hidden!.Value,
					Ability!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record DexEntry : BaseDataItem
	{
		public DexEntry(DataId dataId,
			int dexNum,
			bool suggestedStarer,
			ItemReference<ITypeDefinition> primaryType,
			ItemReference<ITypeDefinition>? secondaryType,
			string name,
			string? variant,
			Height averageHeight,
			Weight averageWeight,
			string category,
			string dexDescription,
			Rank suggestedRank,
			int baseHp,
			ItemReference<ImageRef> primaryImage,
			List<ItemReference<ImageRef>> additionalImages,
			ItemReference<ImageRef> smallImage,
			ItemReference<ImageRef>? shinyImage,
			ItemReference<ImageRef>? smallShinyImage,
			List<AbilityEntry> abilities,
			ItemReference<DexEntry>? baseEvolution,
			ItemReference<EvolutionList>? evolutionList,
			ItemReference<DexEntry>? megaEvolutionBaseEntry,
			List<MegaEvolutionEntry> megaEvolutions,
			int maxStrength,
			int startingStrength,
			int maxDexterity,
			int startingDexterity,
			int maxVitality,
			int startingVitality,
			int maxSpecial,
			int startingSpecial,
			int maxInsight,
			int startingInsight,
			GenderType genderType,
			List<MoveEntry> moveSet) : base(dataId)
		{
			DexNum = dexNum;
			SuggestedStarer = suggestedStarer;
			PrimaryType = primaryType;
			SecondaryType = secondaryType;
			Name = name;
			Variant = variant;
			AverageHeight = averageHeight;
			AverageWeight = averageWeight;
			Category = category;
			DexDescription = dexDescription;
			SuggestedRank = suggestedRank;
			BaseHp = baseHp;
			PrimaryImage = primaryImage;
			AdditionalImages = new List<ItemReference<ImageRef>>(additionalImages).AsReadOnly();
			SmallImage = smallImage;
			ShinyImage = shinyImage;
			SmallShinyImage = smallShinyImage;
			Abilities = new List<AbilityEntry>(abilities).AsReadOnly();
			BaseEvolution = baseEvolution;
			EvolutionList = evolutionList;
			MegaEvolutionBaseEntry = megaEvolutionBaseEntry;
			MegaEvolutions = new List<MegaEvolutionEntry>(megaEvolutions).AsReadOnly();
			MaxStrength = maxStrength;
			StartingStrength = startingStrength;
			MaxDexterity = maxDexterity;
			StartingDexterity = startingDexterity;
			MaxVitality = maxVitality;
			StartingVitality = startingVitality;
			MaxSpecial = maxSpecial;
			StartingSpecial = startingSpecial;
			MaxInsight = maxInsight;
			StartingInsight = startingInsight;
			GenderType = genderType;
			MoveSet = new List<MoveEntry>(moveSet).AsReadOnly();
		}

		public ItemReference<DexEntry> ItemReference => new ItemReference<DexEntry>(DataId, Name);

		/// <summary>
		/// The international dex number of this Pokémon
		/// </summary>
		public int DexNum { get; }
		/// <summary>
		/// Whether or not this Pokémon is recommended as a starter
		/// </summary>
		public bool SuggestedStarer { get; }
		/// <summary>
		/// The primary type of this Pokémon
		/// </summary>
		public ItemReference<ITypeDefinition> PrimaryType { get; }
		/// <summary>
		/// The secondary type of this Pokémon if applicable
		/// </summary>
		public ItemReference<ITypeDefinition>? SecondaryType { get; }
		/// <summary>
		/// The name of this Pokémon
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Regional variant of this Pokémon (if applicable) such as "Galaran"
		/// </summary>
		public string? Variant { get; }
		/// <summary>
		/// The average height of this Pokémon
		/// </summary>
		public Height AverageHeight { get; }
		/// <summary>
		/// The average weight of this Pokémon
		/// </summary>
		public Weight AverageWeight { get; }
		/// <summary>
		/// The descriptive category for this Pokémon
		/// </summary>
		public string Category { get; }
		/// <summary>
		/// The description of this Pokémon
		/// </summary>
		public string DexDescription { get; }
		/// <summary>
		/// Suggested starting rank of this Pokémon
		/// </summary>
		public Rank SuggestedRank { get; }
		/// <summary>
		/// The base hp of this Pokémon
		/// </summary>
		public int BaseHp { get; }
		/// <summary>
		/// Primary display image of this Pokémon
		/// </summary>
		public ItemReference<ImageRef> PrimaryImage { get; }
		/// <summary>
		/// Additional images of this pokemon
		/// </summary>
		public IReadOnlyList<ItemReference<ImageRef>> AdditionalImages { get; }
		/// <summary>
		/// Smaller display image of this Pokémon
		/// </summary>
		public ItemReference<ImageRef> SmallImage { get; }
		/// <summary>
		/// Primary display image of a shiny instance of this Pokémon
		/// </summary>
		public ItemReference<ImageRef>? ShinyImage { get; }
		/// <summary>
		/// Smaller display image of a shiny instance of this Pokémon
		/// </summary>
		public ItemReference<ImageRef>? SmallShinyImage { get; }
		/// <summary>
		/// List of possible abilities this Pokémon can have
		/// </summary>
		public IReadOnlyList<AbilityEntry> Abilities { get; }
		/// <summary>
		/// Base evolution of this Dex Entry. If this entry is the base evolution, it should point to itself. If this entry does not evolve, then this is null
		/// </summary>
		public ItemReference<DexEntry>? BaseEvolution { get; }
		/// <summary>
		/// Evolution line of this Pokémon if applicable
		/// </summary>
		public ItemReference<EvolutionList>? EvolutionList { get; }
		/// <summary>
		/// If this is a mega evolution, then what it evolved from, otherwise null
		/// </summary>
		public ItemReference<DexEntry>? MegaEvolutionBaseEntry { get; }
		/// <summary>
		/// List of possible mega evolutions of this Pokémon and their required items if any
		/// </summary>
		public IReadOnlyList<MegaEvolutionEntry> MegaEvolutions { get; }
		/// <summary>
		/// The maximum strength score this Pokémon can have
		/// </summary>
		public int MaxStrength { get; }
		/// <summary>
		/// The initial strength score this Pokémon has
		/// </summary>
		public int StartingStrength { get; }
		/// <summary>
		/// The maximum dexterity score this Pokémon can have
		/// </summary>
		public int MaxDexterity { get; }
		/// <summary>
		/// The initial dexterity score this Pokémon has
		/// </summary>
		public int StartingDexterity { get; }
		/// <summary>
		/// The maximum vitality score this Pokémon can have
		/// </summary>
		public int MaxVitality { get; }
		/// <summary>
		/// The initial vitality score this Pokémon has
		/// </summary>
		public int StartingVitality { get; }
		/// <summary>
		/// The maximum special score this Pokémon can have
		/// </summary>
		public int MaxSpecial { get; }
		/// <summary>
		/// The initial special score this Pokémon has
		/// </summary>
		public int StartingSpecial { get; }
		/// <summary>
		/// The maximum insight score this Pokémon can have
		/// </summary>
		public int MaxInsight { get; }
		/// <summary>
		/// The initial insight score this Pokémon has
		/// </summary>
		public int StartingInsight { get; }
		/// <summary>
		/// Oficially avaliable genders for this kind of pokémon
		/// </summary>
		public GenderType GenderType { get; }
		/// <summary>
		/// List of moves that this Pokémon can learn
		/// </summary>
		public IReadOnlyList<MoveEntry> MoveSet { get; }
		[XmlType(nameof(DexEntry), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<DexEntry>
		{
			public Builder()
			{
				AdditionalImages = new List<ItemReference<ImageRef>>(10);
				Abilities = new List<AbilityEntry>(10);
				MegaEvolutions = new List<MegaEvolutionEntry>(10);
				MoveSet = new List<MoveEntry>(10);
			}
			public Builder(DexEntry dexEntry)
			{
				DataId = dexEntry.DataId;
				DexNum = dexEntry.DexNum;
				SuggestedStarer = dexEntry.SuggestedStarer;
				PrimaryType = dexEntry.PrimaryType;
				SecondaryType = dexEntry.SecondaryType;
				Name = dexEntry.Name;
				Variant = dexEntry.Variant;
				AverageHeight = dexEntry.AverageHeight;
				AverageWeight = dexEntry.AverageWeight;
				Category = dexEntry.Category;
				DexDescription = dexEntry.DexDescription;
				SuggestedRank = dexEntry.SuggestedRank;
				BaseHp = dexEntry.BaseHp;
				PrimaryImage = dexEntry.PrimaryImage;
				AdditionalImages = new List<ItemReference<ImageRef>>(dexEntry.AdditionalImages);
				SmallImage = dexEntry.SmallImage;
				ShinyImage = dexEntry.ShinyImage;
				SmallShinyImage = dexEntry.SmallShinyImage;
				Abilities = new List<AbilityEntry>(dexEntry.Abilities);
				BaseEvolution = dexEntry.BaseEvolution;
				EvolutionList = dexEntry.EvolutionList;
				MegaEvolutionBaseEntry = dexEntry.MegaEvolutionBaseEntry;
				MegaEvolutions = new List<MegaEvolutionEntry>(dexEntry.MegaEvolutions);
				MaxStrength = dexEntry.MaxStrength;
				StartingStrength = dexEntry.StartingStrength;
				MaxDexterity = dexEntry.MaxDexterity;
				StartingDexterity = dexEntry.StartingDexterity;
				MaxVitality = dexEntry.MaxVitality;
				StartingVitality = dexEntry.StartingVitality;
				MaxSpecial = dexEntry.MaxSpecial;
				StartingSpecial = dexEntry.StartingSpecial;
				MaxInsight = dexEntry.MaxInsight;
				StartingInsight = dexEntry.StartingInsight;
				GenderType = dexEntry.GenderType;
				MoveSet = new List<MoveEntry>(dexEntry.MoveSet);
			}

			public ItemReference<DexEntry>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<DexEntry>(DataId.Value, Name);

			/// <summary>
			/// The international dex number of this Pokémon
			/// </summary>
			[XmlIgnore]
			public int? DexNum { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("DexNum", IsNullable = false)]
			public int DexNumNullableXmlAccessor
			{
				get => DexNum ?? default;
				set => DexNum = value;
			}
			/// <summary>
			/// Whether or not this Pokémon is recommended as a starter
			/// </summary>
			[XmlIgnore]
			public bool? SuggestedStarer { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SuggestedStarer", IsNullable = false)]
			public bool SuggestedStarerNullableXmlAccessor
			{
				get => SuggestedStarer ?? default;
				set => SuggestedStarer = value;
			}
			/// <summary>
			/// The primary type of this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<ITypeDefinition>? PrimaryType { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("PrimaryType", IsNullable = false)]
			public ItemReference<ITypeDefinition>.Builder? PrimaryTypeXmlAccessor
			{
				get => PrimaryType is null ? null : new ItemReference<ITypeDefinition>.Builder(PrimaryType ?? default);
				set => PrimaryType = value?.Build();
			}

			/// <summary>
			/// The secondary type of this Pokémon if applicable
			/// </summary>
			[XmlIgnore]
			public ItemReference<ITypeDefinition>? SecondaryType { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SecondaryType", IsNullable = false)]
			public ItemReference<ITypeDefinition>.Builder? SecondaryTypeXmlAccessor
			{
				get => SecondaryType is null ? null : new ItemReference<ITypeDefinition>.Builder(SecondaryType ?? default);
				set => SecondaryType = value?.Build();
			}

			/// <summary>
			/// The name of this Pokémon
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Name { get; set; }
			/// <summary>
			/// Regional variant of this Pokémon (if applicable) such as "Galaran"
			/// </summary>
			[XmlElement(IsNullable = true)]
			public string? Variant { get; set; }
			/// <summary>
			/// The average height of this Pokémon
			/// </summary>
			[XmlIgnore]
			public Height? AverageHeight { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("AverageHeight", IsNullable = false)]
			public Height.Builder? AverageHeightXmlAccessor
			{
				get => AverageHeight is null ? null : new Height.Builder(AverageHeight ?? default);
				set => AverageHeight = value?.Build();
			}

			/// <summary>
			/// The average weight of this Pokémon
			/// </summary>
			[XmlIgnore]
			public Weight? AverageWeight { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("AverageWeight", IsNullable = false)]
			public Weight.Builder? AverageWeightXmlAccessor
			{
				get => AverageWeight is null ? null : new Weight.Builder(AverageWeight ?? default);
				set => AverageWeight = value?.Build();
			}

			/// <summary>
			/// The descriptive category for this Pokémon
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Category { get; set; }
			/// <summary>
			/// The description of this Pokémon
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? DexDescription { get; set; }
			/// <summary>
			/// Suggested starting rank of this Pokémon
			/// </summary>
			[XmlIgnore]
			public Rank? SuggestedRank { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SuggestedRank", IsNullable = false)]
			public Rank SuggestedRankNullableXmlAccessor
			{
				get => SuggestedRank ?? default;
				set => SuggestedRank = value;
			}
			/// <summary>
			/// The base hp of this Pokémon
			/// </summary>
			[XmlIgnore]
			public int? BaseHp { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("BaseHp", IsNullable = false)]
			public int BaseHpNullableXmlAccessor
			{
				get => BaseHp ?? default;
				set => BaseHp = value;
			}
			/// <summary>
			/// Primary display image of this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<ImageRef>? PrimaryImage { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("PrimaryImage", IsNullable = false)]
			public ItemReference<ImageRef>.Builder? PrimaryImageXmlAccessor
			{
				get => PrimaryImage is null ? null : new ItemReference<ImageRef>.Builder(PrimaryImage ?? default);
				set => PrimaryImage = value?.Build();
			}

			/// <summary>
			/// Additional images of this pokemon
			/// </summary>
			[XmlIgnore]
			public List<ItemReference<ImageRef>> AdditionalImages { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("AdditionalImages", IsNullable = false)]
			[XmlArrayItem("ItemReference")]
			public ItemReference<ImageRef>.Builder[] AdditionalImagesBuilder
			{
				get
				{
					if (AdditionalImages == null)
					{
						return Array.Empty<ItemReference<ImageRef>.Builder>();
					}
					return AdditionalImages.Select(item=>new ItemReference<ImageRef>.Builder(item)).ToArray();
				}
				set
				{
					AdditionalImages?.Clear();
					if (value == null)
					{
						return;
					}
					if (AdditionalImages == null)
					{
						AdditionalImages = new List<ItemReference<ImageRef>>(value.Length);
					}
					ItemBuilder<ItemReference<ImageRef>>.BuildList(value, AdditionalImages);
				}
			}
			/// <summary>
			/// Smaller display image of this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<ImageRef>? SmallImage { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SmallImage", IsNullable = false)]
			public ItemReference<ImageRef>.Builder? SmallImageXmlAccessor
			{
				get => SmallImage is null ? null : new ItemReference<ImageRef>.Builder(SmallImage ?? default);
				set => SmallImage = value?.Build();
			}

			/// <summary>
			/// Primary display image of a shiny instance of this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<ImageRef>? ShinyImage { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("ShinyImage", IsNullable = false)]
			public ItemReference<ImageRef>.Builder? ShinyImageXmlAccessor
			{
				get => ShinyImage is null ? null : new ItemReference<ImageRef>.Builder(ShinyImage ?? default);
				set => ShinyImage = value?.Build();
			}

			/// <summary>
			/// Smaller display image of a shiny instance of this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<ImageRef>? SmallShinyImage { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SmallShinyImage", IsNullable = false)]
			public ItemReference<ImageRef>.Builder? SmallShinyImageXmlAccessor
			{
				get => SmallShinyImage is null ? null : new ItemReference<ImageRef>.Builder(SmallShinyImage ?? default);
				set => SmallShinyImage = value?.Build();
			}

			/// <summary>
			/// List of possible abilities this Pokémon can have
			/// </summary>
			[XmlIgnore]
			public List<AbilityEntry> Abilities { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("Abilities", IsNullable = false)]
			[XmlArrayItem("AbilityEntry")]
			public AbilityEntry.Builder[] AbilitiesBuilder
			{
				get
				{
					if (Abilities == null)
					{
						return Array.Empty<AbilityEntry.Builder>();
					}
					return Abilities.Select(item=>new AbilityEntry.Builder(item)).ToArray();
				}
				set
				{
					Abilities?.Clear();
					if (value == null)
					{
						return;
					}
					if (Abilities == null)
					{
						Abilities = new List<AbilityEntry>(value.Length);
					}
					ItemBuilder<AbilityEntry>.BuildList(value, Abilities);
				}
			}
			/// <summary>
			/// Base evolution of this Dex Entry. If this entry is the base evolution, it should point to itself. If this entry does not evolve, then this is null
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? BaseEvolution { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("BaseEvolution", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? BaseEvolutionXmlAccessor
			{
				get => BaseEvolution is null ? null : new ItemReference<DexEntry>.Builder(BaseEvolution ?? default);
				set => BaseEvolution = value?.Build();
			}

			/// <summary>
			/// Evolution line of this Pokémon if applicable
			/// </summary>
			[XmlIgnore]
			public ItemReference<EvolutionList>? EvolutionList { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("EvolutionList", IsNullable = false)]
			public ItemReference<EvolutionList>.Builder? EvolutionListXmlAccessor
			{
				get => EvolutionList is null ? null : new ItemReference<EvolutionList>.Builder(EvolutionList ?? default);
				set => EvolutionList = value?.Build();
			}

			/// <summary>
			/// If this is a mega evolution, then what it evolved from, otherwise null
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? MegaEvolutionBaseEntry { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MegaEvolutionBaseEntry", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? MegaEvolutionBaseEntryXmlAccessor
			{
				get => MegaEvolutionBaseEntry is null ? null : new ItemReference<DexEntry>.Builder(MegaEvolutionBaseEntry ?? default);
				set => MegaEvolutionBaseEntry = value?.Build();
			}

			/// <summary>
			/// List of possible mega evolutions of this Pokémon and their required items if any
			/// </summary>
			[XmlIgnore]
			public List<MegaEvolutionEntry> MegaEvolutions { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("MegaEvolutions", IsNullable = false)]
			[XmlArrayItem("MegaEvolutionEntry")]
			public MegaEvolutionEntry.Builder[] MegaEvolutionsBuilder
			{
				get
				{
					if (MegaEvolutions == null)
					{
						return Array.Empty<MegaEvolutionEntry.Builder>();
					}
					return MegaEvolutions.Select(item=>new MegaEvolutionEntry.Builder(item)).ToArray();
				}
				set
				{
					MegaEvolutions?.Clear();
					if (value == null)
					{
						return;
					}
					if (MegaEvolutions == null)
					{
						MegaEvolutions = new List<MegaEvolutionEntry>(value.Length);
					}
					ItemBuilder<MegaEvolutionEntry>.BuildList(value, MegaEvolutions);
				}
			}
			/// <summary>
			/// The maximum strength score this Pokémon can have
			/// </summary>
			[XmlIgnore]
			public int? MaxStrength { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MaxStrength", IsNullable = false)]
			public int MaxStrengthNullableXmlAccessor
			{
				get => MaxStrength ?? default;
				set => MaxStrength = value;
			}
			/// <summary>
			/// The initial strength score this Pokémon has
			/// </summary>
			[XmlIgnore]
			public int? StartingStrength { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("StartingStrength", IsNullable = false)]
			public int StartingStrengthNullableXmlAccessor
			{
				get => StartingStrength ?? default;
				set => StartingStrength = value;
			}
			/// <summary>
			/// The maximum dexterity score this Pokémon can have
			/// </summary>
			[XmlIgnore]
			public int? MaxDexterity { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MaxDexterity", IsNullable = false)]
			public int MaxDexterityNullableXmlAccessor
			{
				get => MaxDexterity ?? default;
				set => MaxDexterity = value;
			}
			/// <summary>
			/// The initial dexterity score this Pokémon has
			/// </summary>
			[XmlIgnore]
			public int? StartingDexterity { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("StartingDexterity", IsNullable = false)]
			public int StartingDexterityNullableXmlAccessor
			{
				get => StartingDexterity ?? default;
				set => StartingDexterity = value;
			}
			/// <summary>
			/// The maximum vitality score this Pokémon can have
			/// </summary>
			[XmlIgnore]
			public int? MaxVitality { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MaxVitality", IsNullable = false)]
			public int MaxVitalityNullableXmlAccessor
			{
				get => MaxVitality ?? default;
				set => MaxVitality = value;
			}
			/// <summary>
			/// The initial vitality score this Pokémon has
			/// </summary>
			[XmlIgnore]
			public int? StartingVitality { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("StartingVitality", IsNullable = false)]
			public int StartingVitalityNullableXmlAccessor
			{
				get => StartingVitality ?? default;
				set => StartingVitality = value;
			}
			/// <summary>
			/// The maximum special score this Pokémon can have
			/// </summary>
			[XmlIgnore]
			public int? MaxSpecial { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MaxSpecial", IsNullable = false)]
			public int MaxSpecialNullableXmlAccessor
			{
				get => MaxSpecial ?? default;
				set => MaxSpecial = value;
			}
			/// <summary>
			/// The initial special score this Pokémon has
			/// </summary>
			[XmlIgnore]
			public int? StartingSpecial { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("StartingSpecial", IsNullable = false)]
			public int StartingSpecialNullableXmlAccessor
			{
				get => StartingSpecial ?? default;
				set => StartingSpecial = value;
			}
			/// <summary>
			/// The maximum insight score this Pokémon can have
			/// </summary>
			[XmlIgnore]
			public int? MaxInsight { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MaxInsight", IsNullable = false)]
			public int MaxInsightNullableXmlAccessor
			{
				get => MaxInsight ?? default;
				set => MaxInsight = value;
			}
			/// <summary>
			/// The initial insight score this Pokémon has
			/// </summary>
			[XmlIgnore]
			public int? StartingInsight { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("StartingInsight", IsNullable = false)]
			public int StartingInsightNullableXmlAccessor
			{
				get => StartingInsight ?? default;
				set => StartingInsight = value;
			}
			/// <summary>
			/// Oficially avaliable genders for this kind of pokémon
			/// </summary>
			[XmlIgnore]
			public GenderType? GenderType { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("GenderType", IsNullable = false)]
			public GenderType GenderTypeNullableXmlAccessor
			{
				get => GenderType ?? default;
				set => GenderType = value;
			}
			/// <summary>
			/// List of moves that this Pokémon can learn
			/// </summary>
			[XmlIgnore]
			public List<MoveEntry> MoveSet { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("MoveSet", IsNullable = false)]
			[XmlArrayItem("MoveEntry")]
			public MoveEntry.Builder[] MoveSetBuilder
			{
				get
				{
					if (MoveSet == null)
					{
						return Array.Empty<MoveEntry.Builder>();
					}
					return MoveSet.Select(item=>new MoveEntry.Builder(item)).ToArray();
				}
				set
				{
					MoveSet?.Clear();
					if (value == null)
					{
						return;
					}
					if (MoveSet == null)
					{
						MoveSet = new List<MoveEntry>(value.Length);
					}
					ItemBuilder<MoveEntry>.BuildList(value, MoveSet);
				}
			}
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="DexEntry"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (DexNum is null)
					{
						return false;
					}
					if (SuggestedStarer is null)
					{
						return false;
					}
					if (PrimaryType is null)
					{
						return false;
					}
					if (Name is null)
					{
						return false;
					}
					if (AverageHeight is null)
					{
						return false;
					}
					if (AverageWeight is null)
					{
						return false;
					}
					if (Category is null)
					{
						return false;
					}
					if (DexDescription is null)
					{
						return false;
					}
					if (SuggestedRank is null)
					{
						return false;
					}
					if (BaseHp is null)
					{
						return false;
					}
					if (PrimaryImage is null)
					{
						return false;
					}
					if (AdditionalImages is null)
					{
						return false;
					}
					if (SmallImage is null)
					{
						return false;
					}
					if (Abilities is null)
					{
						return false;
					}
					if (MegaEvolutions is null)
					{
						return false;
					}
					if (MaxStrength is null)
					{
						return false;
					}
					if (StartingStrength is null)
					{
						return false;
					}
					if (MaxDexterity is null)
					{
						return false;
					}
					if (StartingDexterity is null)
					{
						return false;
					}
					if (MaxVitality is null)
					{
						return false;
					}
					if (StartingVitality is null)
					{
						return false;
					}
					if (MaxSpecial is null)
					{
						return false;
					}
					if (StartingSpecial is null)
					{
						return false;
					}
					if (MaxInsight is null)
					{
						return false;
					}
					if (StartingInsight is null)
					{
						return false;
					}
					if (GenderType is null)
					{
						return false;
					}
					if (MoveSet is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="DexEntry"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="DexEntry"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override DexEntry Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new DexEntry(DataId!.Value,
					DexNum!.Value,
					SuggestedStarer!.Value,
					PrimaryType!.Value,
					SecondaryType,
					Name!,
					Variant,
					AverageHeight!.Value,
					AverageWeight!.Value,
					Category!,
					DexDescription!,
					SuggestedRank!.Value,
					BaseHp!.Value,
					PrimaryImage!.Value,
					AdditionalImages!,
					SmallImage!.Value,
					ShinyImage,
					SmallShinyImage,
					Abilities!,
					BaseEvolution,
					EvolutionList,
					MegaEvolutionBaseEntry,
					MegaEvolutions!,
					MaxStrength!.Value,
					StartingStrength!.Value,
					MaxDexterity!.Value,
					StartingDexterity!.Value,
					MaxVitality!.Value,
					StartingVitality!.Value,
					MaxSpecial!.Value,
					StartingSpecial!.Value,
					MaxInsight!.Value,
					StartingInsight!.Value,
					GenderType!.Value,
					MoveSet!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record MonInstance : BaseDataItem
	{
		public MonInstance(DataId dataId,
			ItemReference<ImageRef> picture,
			ItemReference<DexEntry> definition,
			string name,
			ItemReference<Ability> ability,
			ItemReference<Ability>? overiddenAblity,
			ItemReference<ITypeDefinition>? overridenType1,
			ItemReference<ITypeDefinition>? overridenType2,
			ItemReference<ITypeDefinition>? overridenType3,
			int hP,
			int willPoints,
			ItemReference<Item> heldItem,
			List<MonStatus> status,
			int evasionDice,
			int clashDice,
			int defence,
			int specialDefence,
			Rank rank,
			List<MoveEntry> moves,
			Height height,
			Weight weight,
			int strength,
			int dexterity,
			int vitality,
			int special,
			int insight,
			int brawl,
			int channel,
			int clash,
			int evasion,
			int alert,
			int athletic,
			int nature,
			int stealth,
			int allure,
			int etiquette,
			int intimidate,
			int perform,
			List<CustomSkillEntry> customSkills,
			int tough,
			int cool,
			int beauty,
			int clever,
			int cute,
			Nature monNature,
			int happiness,
			int loyalty,
			int battleCount,
			int vicoryCount,
			List<string> accessories,
			List<string> ribbons) : base(dataId)
		{
			Picture = picture;
			Definition = definition;
			Name = name;
			Ability = ability;
			OveriddenAblity = overiddenAblity;
			OverridenType1 = overridenType1;
			OverridenType2 = overridenType2;
			OverridenType3 = overridenType3;
			HP = hP;
			WillPoints = willPoints;
			HeldItem = heldItem;
			Status = new List<MonStatus>(status).AsReadOnly();
			EvasionDice = evasionDice;
			ClashDice = clashDice;
			Defence = defence;
			SpecialDefence = specialDefence;
			Rank = rank;
			Moves = new List<MoveEntry>(moves).AsReadOnly();
			Height = height;
			Weight = weight;
			Strength = strength;
			Dexterity = dexterity;
			Vitality = vitality;
			Special = special;
			Insight = insight;
			Brawl = brawl;
			Channel = channel;
			Clash = clash;
			Evasion = evasion;
			Alert = alert;
			Athletic = athletic;
			Nature = nature;
			Stealth = stealth;
			Allure = allure;
			Etiquette = etiquette;
			Intimidate = intimidate;
			Perform = perform;
			CustomSkills = new List<CustomSkillEntry>(customSkills).AsReadOnly();
			Tough = tough;
			Cool = cool;
			Beauty = beauty;
			Clever = clever;
			Cute = cute;
			MonNature = monNature;
			Happiness = happiness;
			Loyalty = loyalty;
			BattleCount = battleCount;
			VicoryCount = vicoryCount;
			Accessories = new List<string>(accessories).AsReadOnly();
			Ribbons = new List<string>(ribbons).AsReadOnly();
		}

		public ItemReference<MonInstance> ItemReference => new ItemReference<MonInstance>(DataId, Name);

		/// <summary>
		/// Picture of this Pokémon
		/// </summary>
		public ItemReference<ImageRef> Picture { get; }
		/// <summary>
		/// The DexEntry that currently defines this Pokémon
		/// </summary>
		public ItemReference<DexEntry> Definition { get; }
		/// <summary>
		/// The name of this Pokémon
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// This Pokémon's usual ability
		/// </summary>
		public ItemReference<Ability> Ability { get; }
		/// <summary>
		/// This Pokémon's current ability if it isn't the usual ability, such as what happens when one gets hit by simple beam
		/// </summary>
		public ItemReference<Ability>? OveriddenAblity { get; }
		/// <summary>
		/// Override of this Mon's first type if applicable
		/// </summary>
		public ItemReference<ITypeDefinition>? OverridenType1 { get; }
		/// <summary>
		/// Override of this Mon's second type if applicable
		/// </summary>
		public ItemReference<ITypeDefinition>? OverridenType2 { get; }
		/// <summary>
		/// Additional type added to this mon such as by Trick-Or-Treat
		/// </summary>
		public ItemReference<ITypeDefinition>? OverridenType3 { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int HP { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int WillPoints { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public ItemReference<Item> HeldItem { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<MonStatus> Status { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int EvasionDice { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int ClashDice { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Defence { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int SpecialDefence { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public Rank Rank { get; }
		/// <summary>
		/// List of moves this Pokémon knows
		/// </summary>
		public IReadOnlyList<MoveEntry> Moves { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public Height Height { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public Weight Weight { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Strength { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Dexterity { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Vitality { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Special { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Insight { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Brawl { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Channel { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Clash { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Evasion { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Alert { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Athletic { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Nature { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Stealth { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Allure { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Etiquette { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Intimidate { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Perform { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<CustomSkillEntry> CustomSkills { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Tough { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Cool { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Beauty { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Clever { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Cute { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public Nature MonNature { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Happiness { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Loyalty { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int BattleCount { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int VicoryCount { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<string> Accessories { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<string> Ribbons { get; }
		[XmlType(nameof(MonInstance), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<MonInstance>
		{
			public Builder()
			{
				Status = new List<MonStatus>(10);
				Moves = new List<MoveEntry>(10);
				CustomSkills = new List<CustomSkillEntry>(10);
				Accessories = new List<string>(10);
				Ribbons = new List<string>(10);
			}
			public Builder(MonInstance monInstance)
			{
				DataId = monInstance.DataId;
				Picture = monInstance.Picture;
				Definition = monInstance.Definition;
				Name = monInstance.Name;
				Ability = monInstance.Ability;
				OveriddenAblity = monInstance.OveriddenAblity;
				OverridenType1 = monInstance.OverridenType1;
				OverridenType2 = monInstance.OverridenType2;
				OverridenType3 = monInstance.OverridenType3;
				HP = monInstance.HP;
				WillPoints = monInstance.WillPoints;
				HeldItem = monInstance.HeldItem;
				Status = new List<MonStatus>(monInstance.Status);
				EvasionDice = monInstance.EvasionDice;
				ClashDice = monInstance.ClashDice;
				Defence = monInstance.Defence;
				SpecialDefence = monInstance.SpecialDefence;
				Rank = monInstance.Rank;
				Moves = new List<MoveEntry>(monInstance.Moves);
				Height = monInstance.Height;
				Weight = monInstance.Weight;
				Strength = monInstance.Strength;
				Dexterity = monInstance.Dexterity;
				Vitality = monInstance.Vitality;
				Special = monInstance.Special;
				Insight = monInstance.Insight;
				Brawl = monInstance.Brawl;
				Channel = monInstance.Channel;
				Clash = monInstance.Clash;
				Evasion = monInstance.Evasion;
				Alert = monInstance.Alert;
				Athletic = monInstance.Athletic;
				Nature = monInstance.Nature;
				Stealth = monInstance.Stealth;
				Allure = monInstance.Allure;
				Etiquette = monInstance.Etiquette;
				Intimidate = monInstance.Intimidate;
				Perform = monInstance.Perform;
				CustomSkills = new List<CustomSkillEntry>(monInstance.CustomSkills);
				Tough = monInstance.Tough;
				Cool = monInstance.Cool;
				Beauty = monInstance.Beauty;
				Clever = monInstance.Clever;
				Cute = monInstance.Cute;
				MonNature = monInstance.MonNature;
				Happiness = monInstance.Happiness;
				Loyalty = monInstance.Loyalty;
				BattleCount = monInstance.BattleCount;
				VicoryCount = monInstance.VicoryCount;
				Accessories = new List<string>(monInstance.Accessories);
				Ribbons = new List<string>(monInstance.Ribbons);
			}

			public ItemReference<MonInstance>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<MonInstance>(DataId.Value, Name);

			/// <summary>
			/// Picture of this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<ImageRef>? Picture { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Picture", IsNullable = false)]
			public ItemReference<ImageRef>.Builder? PictureXmlAccessor
			{
				get => Picture is null ? null : new ItemReference<ImageRef>.Builder(Picture ?? default);
				set => Picture = value?.Build();
			}

			/// <summary>
			/// The DexEntry that currently defines this Pokémon
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? Definition { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Definition", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? DefinitionXmlAccessor
			{
				get => Definition is null ? null : new ItemReference<DexEntry>.Builder(Definition ?? default);
				set => Definition = value?.Build();
			}

			/// <summary>
			/// The name of this Pokémon
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Name { get; set; }
			/// <summary>
			/// This Pokémon's usual ability
			/// </summary>
			[XmlIgnore]
			public ItemReference<Ability>? Ability { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Ability", IsNullable = false)]
			public ItemReference<Ability>.Builder? AbilityXmlAccessor
			{
				get => Ability is null ? null : new ItemReference<Ability>.Builder(Ability ?? default);
				set => Ability = value?.Build();
			}

			/// <summary>
			/// This Pokémon's current ability if it isn't the usual ability, such as what happens when one gets hit by simple beam
			/// </summary>
			[XmlIgnore]
			public ItemReference<Ability>? OveriddenAblity { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("OveriddenAblity", IsNullable = false)]
			public ItemReference<Ability>.Builder? OveriddenAblityXmlAccessor
			{
				get => OveriddenAblity is null ? null : new ItemReference<Ability>.Builder(OveriddenAblity ?? default);
				set => OveriddenAblity = value?.Build();
			}

			/// <summary>
			/// Override of this Mon's first type if applicable
			/// </summary>
			[XmlIgnore]
			public ItemReference<ITypeDefinition>? OverridenType1 { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("OverridenType1", IsNullable = false)]
			public ItemReference<ITypeDefinition>.Builder? OverridenType1XmlAccessor
			{
				get => OverridenType1 is null ? null : new ItemReference<ITypeDefinition>.Builder(OverridenType1 ?? default);
				set => OverridenType1 = value?.Build();
			}

			/// <summary>
			/// Override of this Mon's second type if applicable
			/// </summary>
			[XmlIgnore]
			public ItemReference<ITypeDefinition>? OverridenType2 { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("OverridenType2", IsNullable = false)]
			public ItemReference<ITypeDefinition>.Builder? OverridenType2XmlAccessor
			{
				get => OverridenType2 is null ? null : new ItemReference<ITypeDefinition>.Builder(OverridenType2 ?? default);
				set => OverridenType2 = value?.Build();
			}

			/// <summary>
			/// Additional type added to this mon such as by Trick-Or-Treat
			/// </summary>
			[XmlIgnore]
			public ItemReference<ITypeDefinition>? OverridenType3 { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("OverridenType3", IsNullable = false)]
			public ItemReference<ITypeDefinition>.Builder? OverridenType3XmlAccessor
			{
				get => OverridenType3 is null ? null : new ItemReference<ITypeDefinition>.Builder(OverridenType3 ?? default);
				set => OverridenType3 = value?.Build();
			}

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? HP { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HP", IsNullable = false)]
			public int HPNullableXmlAccessor
			{
				get => HP ?? default;
				set => HP = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? WillPoints { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("WillPoints", IsNullable = false)]
			public int WillPointsNullableXmlAccessor
			{
				get => WillPoints ?? default;
				set => WillPoints = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public ItemReference<Item>? HeldItem { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HeldItem", IsNullable = false)]
			public ItemReference<Item>.Builder? HeldItemXmlAccessor
			{
				get => HeldItem is null ? null : new ItemReference<Item>.Builder(HeldItem ?? default);
				set => HeldItem = value?.Build();
			}

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<MonStatus> Status { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? EvasionDice { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("EvasionDice", IsNullable = false)]
			public int EvasionDiceNullableXmlAccessor
			{
				get => EvasionDice ?? default;
				set => EvasionDice = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? ClashDice { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("ClashDice", IsNullable = false)]
			public int ClashDiceNullableXmlAccessor
			{
				get => ClashDice ?? default;
				set => ClashDice = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Defence { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Defence", IsNullable = false)]
			public int DefenceNullableXmlAccessor
			{
				get => Defence ?? default;
				set => Defence = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? SpecialDefence { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SpecialDefence", IsNullable = false)]
			public int SpecialDefenceNullableXmlAccessor
			{
				get => SpecialDefence ?? default;
				set => SpecialDefence = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public Rank? Rank { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Rank", IsNullable = false)]
			public Rank RankNullableXmlAccessor
			{
				get => Rank ?? default;
				set => Rank = value;
			}
			/// <summary>
			/// List of moves this Pokémon knows
			/// </summary>
			[XmlIgnore]
			public List<MoveEntry> Moves { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("Moves", IsNullable = false)]
			[XmlArrayItem("MoveEntry")]
			public MoveEntry.Builder[] MovesBuilder
			{
				get
				{
					if (Moves == null)
					{
						return Array.Empty<MoveEntry.Builder>();
					}
					return Moves.Select(item=>new MoveEntry.Builder(item)).ToArray();
				}
				set
				{
					Moves?.Clear();
					if (value == null)
					{
						return;
					}
					if (Moves == null)
					{
						Moves = new List<MoveEntry>(value.Length);
					}
					ItemBuilder<MoveEntry>.BuildList(value, Moves);
				}
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public Height? Height { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Height", IsNullable = false)]
			public Height.Builder? HeightXmlAccessor
			{
				get => Height is null ? null : new Height.Builder(Height ?? default);
				set => Height = value?.Build();
			}

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public Weight? Weight { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Weight", IsNullable = false)]
			public Weight.Builder? WeightXmlAccessor
			{
				get => Weight is null ? null : new Weight.Builder(Weight ?? default);
				set => Weight = value?.Build();
			}

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Strength { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Strength", IsNullable = false)]
			public int StrengthNullableXmlAccessor
			{
				get => Strength ?? default;
				set => Strength = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Dexterity { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Dexterity", IsNullable = false)]
			public int DexterityNullableXmlAccessor
			{
				get => Dexterity ?? default;
				set => Dexterity = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Vitality { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Vitality", IsNullable = false)]
			public int VitalityNullableXmlAccessor
			{
				get => Vitality ?? default;
				set => Vitality = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Special { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Special", IsNullable = false)]
			public int SpecialNullableXmlAccessor
			{
				get => Special ?? default;
				set => Special = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Insight { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Insight", IsNullable = false)]
			public int InsightNullableXmlAccessor
			{
				get => Insight ?? default;
				set => Insight = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Brawl { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Brawl", IsNullable = false)]
			public int BrawlNullableXmlAccessor
			{
				get => Brawl ?? default;
				set => Brawl = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Channel { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Channel", IsNullable = false)]
			public int ChannelNullableXmlAccessor
			{
				get => Channel ?? default;
				set => Channel = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Clash { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Clash", IsNullable = false)]
			public int ClashNullableXmlAccessor
			{
				get => Clash ?? default;
				set => Clash = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Evasion { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Evasion", IsNullable = false)]
			public int EvasionNullableXmlAccessor
			{
				get => Evasion ?? default;
				set => Evasion = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Alert { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Alert", IsNullable = false)]
			public int AlertNullableXmlAccessor
			{
				get => Alert ?? default;
				set => Alert = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Athletic { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Athletic", IsNullable = false)]
			public int AthleticNullableXmlAccessor
			{
				get => Athletic ?? default;
				set => Athletic = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Nature { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Nature", IsNullable = false)]
			public int NatureNullableXmlAccessor
			{
				get => Nature ?? default;
				set => Nature = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Stealth { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Stealth", IsNullable = false)]
			public int StealthNullableXmlAccessor
			{
				get => Stealth ?? default;
				set => Stealth = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Allure { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Allure", IsNullable = false)]
			public int AllureNullableXmlAccessor
			{
				get => Allure ?? default;
				set => Allure = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Etiquette { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Etiquette", IsNullable = false)]
			public int EtiquetteNullableXmlAccessor
			{
				get => Etiquette ?? default;
				set => Etiquette = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Intimidate { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Intimidate", IsNullable = false)]
			public int IntimidateNullableXmlAccessor
			{
				get => Intimidate ?? default;
				set => Intimidate = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Perform { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Perform", IsNullable = false)]
			public int PerformNullableXmlAccessor
			{
				get => Perform ?? default;
				set => Perform = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public List<CustomSkillEntry> CustomSkills { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("CustomSkills", IsNullable = false)]
			[XmlArrayItem("CustomSkillEntry")]
			public CustomSkillEntry.Builder[] CustomSkillsBuilder
			{
				get
				{
					if (CustomSkills == null)
					{
						return Array.Empty<CustomSkillEntry.Builder>();
					}
					return CustomSkills.Select(item=>new CustomSkillEntry.Builder(item)).ToArray();
				}
				set
				{
					CustomSkills?.Clear();
					if (value == null)
					{
						return;
					}
					if (CustomSkills == null)
					{
						CustomSkills = new List<CustomSkillEntry>(value.Length);
					}
					ItemBuilder<CustomSkillEntry>.BuildList(value, CustomSkills);
				}
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Tough { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Tough", IsNullable = false)]
			public int ToughNullableXmlAccessor
			{
				get => Tough ?? default;
				set => Tough = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Cool { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Cool", IsNullable = false)]
			public int CoolNullableXmlAccessor
			{
				get => Cool ?? default;
				set => Cool = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Beauty { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Beauty", IsNullable = false)]
			public int BeautyNullableXmlAccessor
			{
				get => Beauty ?? default;
				set => Beauty = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Clever { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Clever", IsNullable = false)]
			public int CleverNullableXmlAccessor
			{
				get => Clever ?? default;
				set => Clever = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Cute { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Cute", IsNullable = false)]
			public int CuteNullableXmlAccessor
			{
				get => Cute ?? default;
				set => Cute = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public Nature? MonNature { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MonNature", IsNullable = false)]
			public Nature MonNatureNullableXmlAccessor
			{
				get => MonNature ?? default;
				set => MonNature = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Happiness { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Happiness", IsNullable = false)]
			public int HappinessNullableXmlAccessor
			{
				get => Happiness ?? default;
				set => Happiness = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Loyalty { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Loyalty", IsNullable = false)]
			public int LoyaltyNullableXmlAccessor
			{
				get => Loyalty ?? default;
				set => Loyalty = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? BattleCount { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("BattleCount", IsNullable = false)]
			public int BattleCountNullableXmlAccessor
			{
				get => BattleCount ?? default;
				set => BattleCount = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? VicoryCount { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("VicoryCount", IsNullable = false)]
			public int VicoryCountNullableXmlAccessor
			{
				get => VicoryCount ?? default;
				set => VicoryCount = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<string> Accessories { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<string> Ribbons { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="MonInstance"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (Picture is null)
					{
						return false;
					}
					if (Definition is null)
					{
						return false;
					}
					if (Name is null)
					{
						return false;
					}
					if (Ability is null)
					{
						return false;
					}
					if (HP is null)
					{
						return false;
					}
					if (WillPoints is null)
					{
						return false;
					}
					if (HeldItem is null)
					{
						return false;
					}
					if (Status is null)
					{
						return false;
					}
					if (EvasionDice is null)
					{
						return false;
					}
					if (ClashDice is null)
					{
						return false;
					}
					if (Defence is null)
					{
						return false;
					}
					if (SpecialDefence is null)
					{
						return false;
					}
					if (Rank is null)
					{
						return false;
					}
					if (Moves is null)
					{
						return false;
					}
					if (Height is null)
					{
						return false;
					}
					if (Weight is null)
					{
						return false;
					}
					if (Strength is null)
					{
						return false;
					}
					if (Dexterity is null)
					{
						return false;
					}
					if (Vitality is null)
					{
						return false;
					}
					if (Special is null)
					{
						return false;
					}
					if (Insight is null)
					{
						return false;
					}
					if (Brawl is null)
					{
						return false;
					}
					if (Channel is null)
					{
						return false;
					}
					if (Clash is null)
					{
						return false;
					}
					if (Evasion is null)
					{
						return false;
					}
					if (Alert is null)
					{
						return false;
					}
					if (Athletic is null)
					{
						return false;
					}
					if (Nature is null)
					{
						return false;
					}
					if (Stealth is null)
					{
						return false;
					}
					if (Allure is null)
					{
						return false;
					}
					if (Etiquette is null)
					{
						return false;
					}
					if (Intimidate is null)
					{
						return false;
					}
					if (Perform is null)
					{
						return false;
					}
					if (CustomSkills is null)
					{
						return false;
					}
					if (Tough is null)
					{
						return false;
					}
					if (Cool is null)
					{
						return false;
					}
					if (Beauty is null)
					{
						return false;
					}
					if (Clever is null)
					{
						return false;
					}
					if (Cute is null)
					{
						return false;
					}
					if (MonNature is null)
					{
						return false;
					}
					if (Happiness is null)
					{
						return false;
					}
					if (Loyalty is null)
					{
						return false;
					}
					if (BattleCount is null)
					{
						return false;
					}
					if (VicoryCount is null)
					{
						return false;
					}
					if (Accessories is null)
					{
						return false;
					}
					if (Ribbons is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="MonInstance"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="MonInstance"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override MonInstance Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new MonInstance(DataId!.Value,
					Picture!.Value,
					Definition!.Value,
					Name!,
					Ability!.Value,
					OveriddenAblity,
					OverridenType1,
					OverridenType2,
					OverridenType3,
					HP!.Value,
					WillPoints!.Value,
					HeldItem!.Value,
					Status!,
					EvasionDice!.Value,
					ClashDice!.Value,
					Defence!.Value,
					SpecialDefence!.Value,
					Rank!.Value,
					Moves!,
					Height!.Value,
					Weight!.Value,
					Strength!.Value,
					Dexterity!.Value,
					Vitality!.Value,
					Special!.Value,
					Insight!.Value,
					Brawl!.Value,
					Channel!.Value,
					Clash!.Value,
					Evasion!.Value,
					Alert!.Value,
					Athletic!.Value,
					Nature!.Value,
					Stealth!.Value,
					Allure!.Value,
					Etiquette!.Value,
					Intimidate!.Value,
					Perform!.Value,
					CustomSkills!,
					Tough!.Value,
					Cool!.Value,
					Beauty!.Value,
					Clever!.Value,
					Cute!.Value,
					MonNature!.Value,
					Happiness!.Value,
					Loyalty!.Value,
					BattleCount!.Value,
					VicoryCount!.Value,
					Accessories!,
					Ribbons!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record Ability : BaseDataItem
	{
		public Ability(DataId dataId,
			string name,
			string effect) : base(dataId)
		{
			Name = name;
			Effect = effect;
		}

		public ItemReference<Ability> ItemReference => new ItemReference<Ability>(DataId, Name);

		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Effect { get; }
		[XmlType(nameof(Ability), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<Ability>
		{
			public Builder()
			{			}
			public Builder(Ability ability)
			{
				DataId = ability.DataId;
				Name = ability.Name;
				Effect = ability.Effect;
			}

			public ItemReference<Ability>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<Ability>(DataId.Value, Name);

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Name { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Effect { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Ability"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (Name is null)
					{
						return false;
					}
					if (Effect is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Ability"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Ability"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Ability Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Ability(DataId!.Value,
					Name!,
					Effect!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public record EvolutionEntry
	{
		public EvolutionEntry(ItemReference<DexEntry> baseEvolution,
			ItemReference<DexEntry> from,
			ItemReference<DexEntry> to,
			EvolutionKind kind,
			string details)
		{
			BaseEvolution = baseEvolution;
			From = from;
			To = to;
			Kind = kind;
			Details = details;
		}
		/// <summary>
		/// The lowest form of this evolution chain
		/// </summary>
		public ItemReference<DexEntry> BaseEvolution { get; }
		/// <summary>
		/// What it is being evolved from
		/// </summary>
		public ItemReference<DexEntry> From { get; }
		/// <summary>
		/// What it is being evolved to
		/// </summary>
		public ItemReference<DexEntry> To { get; }
		/// <summary>
		/// Type of evolution (for quick filtering)
		/// </summary>
		public EvolutionKind Kind { get; }
		/// <summary>
		/// Further details about how the evolution works. This could be a level number, name of an item, or just about anything really...
		/// </summary>
		public string Details { get; }
		[XmlType(nameof(EvolutionEntry), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<EvolutionEntry>
		{
			public Builder()
			{			}
			public Builder(EvolutionEntry evolutionEntry)
			{
				BaseEvolution = evolutionEntry.BaseEvolution;
				From = evolutionEntry.From;
				To = evolutionEntry.To;
				Kind = evolutionEntry.Kind;
				Details = evolutionEntry.Details;
			}
			/// <summary>
			/// The lowest form of this evolution chain
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? BaseEvolution { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("BaseEvolution", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? BaseEvolutionXmlAccessor
			{
				get => BaseEvolution is null ? null : new ItemReference<DexEntry>.Builder(BaseEvolution ?? default);
				set => BaseEvolution = value?.Build();
			}

			/// <summary>
			/// What it is being evolved from
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? From { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("From", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? FromXmlAccessor
			{
				get => From is null ? null : new ItemReference<DexEntry>.Builder(From ?? default);
				set => From = value?.Build();
			}

			/// <summary>
			/// What it is being evolved to
			/// </summary>
			[XmlIgnore]
			public ItemReference<DexEntry>? To { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("To", IsNullable = false)]
			public ItemReference<DexEntry>.Builder? ToXmlAccessor
			{
				get => To is null ? null : new ItemReference<DexEntry>.Builder(To ?? default);
				set => To = value?.Build();
			}

			/// <summary>
			/// Type of evolution (for quick filtering)
			/// </summary>
			[XmlIgnore]
			public EvolutionKind? Kind { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Kind", IsNullable = false)]
			public EvolutionKind KindNullableXmlAccessor
			{
				get => Kind ?? default;
				set => Kind = value;
			}
			/// <summary>
			/// Further details about how the evolution works. This could be a level number, name of an item, or just about anything really...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Details { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="EvolutionEntry"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (BaseEvolution is null)
					{
						return false;
					}
					if (From is null)
					{
						return false;
					}
					if (To is null)
					{
						return false;
					}
					if (Kind is null)
					{
						return false;
					}
					if (Details is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="EvolutionEntry"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="EvolutionEntry"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override EvolutionEntry Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new EvolutionEntry(
					BaseEvolution!.Value,
					From!.Value,
					To!.Value,
					Kind!.Value,
					Details!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record Trainer : BaseDataItem
	{
		public Trainer(DataId dataId,
			string characterName,
			string playerName,
			Rank rank,
			string age,
			string concept,
			Nature trainerNature,
			string money,
			int hP,
			int willPoints,
			List<ItemReference<MonInstance>> party,
			int strength,
			int dexterity,
			int vitality,
			int insight,
			int tough,
			int cool,
			int beauty,
			int clever,
			int cute,
			int brawl,
			int @throw,
			int evasion,
			int weapons,
			int alert,
			int athletic,
			int nature,
			int stealth,
			int allure,
			int etiquette,
			int intimidate,
			int perform,
			int crafts,
			int lore,
			int medicine,
			int science,
			List<string> achievements,
			int monSeen,
			int monCaught,
			ItemReference<Backpack> backpack) : base(dataId)
		{
			CharacterName = characterName;
			PlayerName = playerName;
			Rank = rank;
			Age = age;
			Concept = concept;
			TrainerNature = trainerNature;
			Money = money;
			HP = hP;
			WillPoints = willPoints;
			Party = new List<ItemReference<MonInstance>>(party).AsReadOnly();
			Strength = strength;
			Dexterity = dexterity;
			Vitality = vitality;
			Insight = insight;
			Tough = tough;
			Cool = cool;
			Beauty = beauty;
			Clever = clever;
			Cute = cute;
			Brawl = brawl;
			Throw = @throw;
			Evasion = evasion;
			Weapons = weapons;
			Alert = alert;
			Athletic = athletic;
			Nature = nature;
			Stealth = stealth;
			Allure = allure;
			Etiquette = etiquette;
			Intimidate = intimidate;
			Perform = perform;
			Crafts = crafts;
			Lore = lore;
			Medicine = medicine;
			Science = science;
			Achievements = new List<string>(achievements).AsReadOnly();
			MonSeen = monSeen;
			MonCaught = monCaught;
			Backpack = backpack;
		}

		public ItemReference<Trainer> ItemReference => new ItemReference<Trainer>(DataId);

		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string CharacterName { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string PlayerName { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public Rank Rank { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Age { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Concept { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public Nature TrainerNature { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Money { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int HP { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int WillPoints { get; }
		/// <summary>
		/// Pokemon in this trainer's party
		/// </summary>
		public IReadOnlyList<ItemReference<MonInstance>> Party { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Strength { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Dexterity { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Vitality { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Insight { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Tough { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Cool { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Beauty { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Clever { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Cute { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Brawl { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Throw { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Evasion { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Weapons { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Alert { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Athletic { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Nature { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Stealth { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Allure { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Etiquette { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Intimidate { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Perform { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Crafts { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Lore { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Medicine { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int Science { get; }
		/// <summary>
		/// Achivements this trainer has accomplished
		/// </summary>
		public IReadOnlyList<string> Achievements { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int MonSeen { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int MonCaught { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public ItemReference<Backpack> Backpack { get; }
		[XmlType(nameof(Trainer), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<Trainer>
		{
			public Builder()
			{
				Party = new List<ItemReference<MonInstance>>(10);
				Achievements = new List<string>(10);
			}
			public Builder(Trainer trainer)
			{
				DataId = trainer.DataId;
				CharacterName = trainer.CharacterName;
				PlayerName = trainer.PlayerName;
				Rank = trainer.Rank;
				Age = trainer.Age;
				Concept = trainer.Concept;
				TrainerNature = trainer.TrainerNature;
				Money = trainer.Money;
				HP = trainer.HP;
				WillPoints = trainer.WillPoints;
				Party = new List<ItemReference<MonInstance>>(trainer.Party);
				Strength = trainer.Strength;
				Dexterity = trainer.Dexterity;
				Vitality = trainer.Vitality;
				Insight = trainer.Insight;
				Tough = trainer.Tough;
				Cool = trainer.Cool;
				Beauty = trainer.Beauty;
				Clever = trainer.Clever;
				Cute = trainer.Cute;
				Brawl = trainer.Brawl;
				Throw = trainer.Throw;
				Evasion = trainer.Evasion;
				Weapons = trainer.Weapons;
				Alert = trainer.Alert;
				Athletic = trainer.Athletic;
				Nature = trainer.Nature;
				Stealth = trainer.Stealth;
				Allure = trainer.Allure;
				Etiquette = trainer.Etiquette;
				Intimidate = trainer.Intimidate;
				Perform = trainer.Perform;
				Crafts = trainer.Crafts;
				Lore = trainer.Lore;
				Medicine = trainer.Medicine;
				Science = trainer.Science;
				Achievements = new List<string>(trainer.Achievements);
				MonSeen = trainer.MonSeen;
				MonCaught = trainer.MonCaught;
				Backpack = trainer.Backpack;
			}

			public ItemReference<Trainer>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<Trainer>(DataId.Value);

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? CharacterName { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? PlayerName { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public Rank? Rank { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Rank", IsNullable = false)]
			public Rank RankNullableXmlAccessor
			{
				get => Rank ?? default;
				set => Rank = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Age { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Concept { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public Nature? TrainerNature { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("TrainerNature", IsNullable = false)]
			public Nature TrainerNatureNullableXmlAccessor
			{
				get => TrainerNature ?? default;
				set => TrainerNature = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Money { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? HP { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HP", IsNullable = false)]
			public int HPNullableXmlAccessor
			{
				get => HP ?? default;
				set => HP = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? WillPoints { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("WillPoints", IsNullable = false)]
			public int WillPointsNullableXmlAccessor
			{
				get => WillPoints ?? default;
				set => WillPoints = value;
			}
			/// <summary>
			/// Pokemon in this trainer's party
			/// </summary>
			[XmlIgnore]
			public List<ItemReference<MonInstance>> Party { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("Party", IsNullable = false)]
			[XmlArrayItem("ItemReference")]
			public ItemReference<MonInstance>.Builder[] PartyBuilder
			{
				get
				{
					if (Party == null)
					{
						return Array.Empty<ItemReference<MonInstance>.Builder>();
					}
					return Party.Select(item=>new ItemReference<MonInstance>.Builder(item)).ToArray();
				}
				set
				{
					Party?.Clear();
					if (value == null)
					{
						return;
					}
					if (Party == null)
					{
						Party = new List<ItemReference<MonInstance>>(value.Length);
					}
					ItemBuilder<ItemReference<MonInstance>>.BuildList(value, Party);
				}
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Strength { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Strength", IsNullable = false)]
			public int StrengthNullableXmlAccessor
			{
				get => Strength ?? default;
				set => Strength = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Dexterity { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Dexterity", IsNullable = false)]
			public int DexterityNullableXmlAccessor
			{
				get => Dexterity ?? default;
				set => Dexterity = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Vitality { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Vitality", IsNullable = false)]
			public int VitalityNullableXmlAccessor
			{
				get => Vitality ?? default;
				set => Vitality = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Insight { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Insight", IsNullable = false)]
			public int InsightNullableXmlAccessor
			{
				get => Insight ?? default;
				set => Insight = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Tough { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Tough", IsNullable = false)]
			public int ToughNullableXmlAccessor
			{
				get => Tough ?? default;
				set => Tough = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Cool { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Cool", IsNullable = false)]
			public int CoolNullableXmlAccessor
			{
				get => Cool ?? default;
				set => Cool = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Beauty { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Beauty", IsNullable = false)]
			public int BeautyNullableXmlAccessor
			{
				get => Beauty ?? default;
				set => Beauty = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Clever { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Clever", IsNullable = false)]
			public int CleverNullableXmlAccessor
			{
				get => Clever ?? default;
				set => Clever = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Cute { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Cute", IsNullable = false)]
			public int CuteNullableXmlAccessor
			{
				get => Cute ?? default;
				set => Cute = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Brawl { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Brawl", IsNullable = false)]
			public int BrawlNullableXmlAccessor
			{
				get => Brawl ?? default;
				set => Brawl = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Throw { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Throw", IsNullable = false)]
			public int ThrowNullableXmlAccessor
			{
				get => Throw ?? default;
				set => Throw = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Evasion { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Evasion", IsNullable = false)]
			public int EvasionNullableXmlAccessor
			{
				get => Evasion ?? default;
				set => Evasion = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Weapons { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Weapons", IsNullable = false)]
			public int WeaponsNullableXmlAccessor
			{
				get => Weapons ?? default;
				set => Weapons = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Alert { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Alert", IsNullable = false)]
			public int AlertNullableXmlAccessor
			{
				get => Alert ?? default;
				set => Alert = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Athletic { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Athletic", IsNullable = false)]
			public int AthleticNullableXmlAccessor
			{
				get => Athletic ?? default;
				set => Athletic = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Nature { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Nature", IsNullable = false)]
			public int NatureNullableXmlAccessor
			{
				get => Nature ?? default;
				set => Nature = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Stealth { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Stealth", IsNullable = false)]
			public int StealthNullableXmlAccessor
			{
				get => Stealth ?? default;
				set => Stealth = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Allure { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Allure", IsNullable = false)]
			public int AllureNullableXmlAccessor
			{
				get => Allure ?? default;
				set => Allure = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Etiquette { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Etiquette", IsNullable = false)]
			public int EtiquetteNullableXmlAccessor
			{
				get => Etiquette ?? default;
				set => Etiquette = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Intimidate { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Intimidate", IsNullable = false)]
			public int IntimidateNullableXmlAccessor
			{
				get => Intimidate ?? default;
				set => Intimidate = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Perform { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Perform", IsNullable = false)]
			public int PerformNullableXmlAccessor
			{
				get => Perform ?? default;
				set => Perform = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Crafts { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Crafts", IsNullable = false)]
			public int CraftsNullableXmlAccessor
			{
				get => Crafts ?? default;
				set => Crafts = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Lore { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Lore", IsNullable = false)]
			public int LoreNullableXmlAccessor
			{
				get => Lore ?? default;
				set => Lore = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Medicine { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Medicine", IsNullable = false)]
			public int MedicineNullableXmlAccessor
			{
				get => Medicine ?? default;
				set => Medicine = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? Science { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Science", IsNullable = false)]
			public int ScienceNullableXmlAccessor
			{
				get => Science ?? default;
				set => Science = value;
			}
			/// <summary>
			/// Achivements this trainer has accomplished
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<string> Achievements { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? MonSeen { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MonSeen", IsNullable = false)]
			public int MonSeenNullableXmlAccessor
			{
				get => MonSeen ?? default;
				set => MonSeen = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? MonCaught { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("MonCaught", IsNullable = false)]
			public int MonCaughtNullableXmlAccessor
			{
				get => MonCaught ?? default;
				set => MonCaught = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public ItemReference<Backpack>? Backpack { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Backpack", IsNullable = false)]
			public ItemReference<Backpack>.Builder? BackpackXmlAccessor
			{
				get => Backpack is null ? null : new ItemReference<Backpack>.Builder(Backpack ?? default);
				set => Backpack = value?.Build();
			}

			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Trainer"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (CharacterName is null)
					{
						return false;
					}
					if (PlayerName is null)
					{
						return false;
					}
					if (Rank is null)
					{
						return false;
					}
					if (Age is null)
					{
						return false;
					}
					if (Concept is null)
					{
						return false;
					}
					if (TrainerNature is null)
					{
						return false;
					}
					if (Money is null)
					{
						return false;
					}
					if (HP is null)
					{
						return false;
					}
					if (WillPoints is null)
					{
						return false;
					}
					if (Party is null)
					{
						return false;
					}
					if (Strength is null)
					{
						return false;
					}
					if (Dexterity is null)
					{
						return false;
					}
					if (Vitality is null)
					{
						return false;
					}
					if (Insight is null)
					{
						return false;
					}
					if (Tough is null)
					{
						return false;
					}
					if (Cool is null)
					{
						return false;
					}
					if (Beauty is null)
					{
						return false;
					}
					if (Clever is null)
					{
						return false;
					}
					if (Cute is null)
					{
						return false;
					}
					if (Brawl is null)
					{
						return false;
					}
					if (Throw is null)
					{
						return false;
					}
					if (Evasion is null)
					{
						return false;
					}
					if (Weapons is null)
					{
						return false;
					}
					if (Alert is null)
					{
						return false;
					}
					if (Athletic is null)
					{
						return false;
					}
					if (Nature is null)
					{
						return false;
					}
					if (Stealth is null)
					{
						return false;
					}
					if (Allure is null)
					{
						return false;
					}
					if (Etiquette is null)
					{
						return false;
					}
					if (Intimidate is null)
					{
						return false;
					}
					if (Perform is null)
					{
						return false;
					}
					if (Crafts is null)
					{
						return false;
					}
					if (Lore is null)
					{
						return false;
					}
					if (Medicine is null)
					{
						return false;
					}
					if (Science is null)
					{
						return false;
					}
					if (Achievements is null)
					{
						return false;
					}
					if (MonSeen is null)
					{
						return false;
					}
					if (MonCaught is null)
					{
						return false;
					}
					if (Backpack is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Trainer"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Trainer"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Trainer Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Trainer(DataId!.Value,
					CharacterName!,
					PlayerName!,
					Rank!.Value,
					Age!,
					Concept!,
					TrainerNature!.Value,
					Money!,
					HP!.Value,
					WillPoints!.Value,
					Party!,
					Strength!.Value,
					Dexterity!.Value,
					Vitality!.Value,
					Insight!.Value,
					Tough!.Value,
					Cool!.Value,
					Beauty!.Value,
					Clever!.Value,
					Cute!.Value,
					Brawl!.Value,
					Throw!.Value,
					Evasion!.Value,
					Weapons!.Value,
					Alert!.Value,
					Athletic!.Value,
					Nature!.Value,
					Stealth!.Value,
					Allure!.Value,
					Etiquette!.Value,
					Intimidate!.Value,
					Perform!.Value,
					Crafts!.Value,
					Lore!.Value,
					Medicine!.Value,
					Science!.Value,
					Achievements!,
					MonSeen!.Value,
					MonCaught!.Value,
					Backpack!.Value);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record Backpack : BaseDataItem
	{
		public Backpack(DataId dataId,
			int potionCount,
			int superPotionCount,
			int hyperPotionCount,
			List<ItemReference<Item>> battleItems,
			List<ItemReference<Item>> otherItems,
			List<string> badges) : base(dataId)
		{
			PotionCount = potionCount;
			SuperPotionCount = superPotionCount;
			HyperPotionCount = hyperPotionCount;
			BattleItems = new List<ItemReference<Item>>(battleItems).AsReadOnly();
			OtherItems = new List<ItemReference<Item>>(otherItems).AsReadOnly();
			Badges = new List<string>(badges).AsReadOnly();
		}

		public ItemReference<Backpack> ItemReference => new ItemReference<Backpack>(DataId);

		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int PotionCount { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int SuperPotionCount { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public int HyperPotionCount { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<ItemReference<Item>> BattleItems { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<ItemReference<Item>> OtherItems { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public IReadOnlyList<string> Badges { get; }
		[XmlType(nameof(Backpack), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<Backpack>
		{
			public Builder()
			{
				BattleItems = new List<ItemReference<Item>>(10);
				OtherItems = new List<ItemReference<Item>>(10);
				Badges = new List<string>(10);
			}
			public Builder(Backpack backpack)
			{
				DataId = backpack.DataId;
				PotionCount = backpack.PotionCount;
				SuperPotionCount = backpack.SuperPotionCount;
				HyperPotionCount = backpack.HyperPotionCount;
				BattleItems = new List<ItemReference<Item>>(backpack.BattleItems);
				OtherItems = new List<ItemReference<Item>>(backpack.OtherItems);
				Badges = new List<string>(backpack.Badges);
			}

			public ItemReference<Backpack>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<Backpack>(DataId.Value);

			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? PotionCount { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("PotionCount", IsNullable = false)]
			public int PotionCountNullableXmlAccessor
			{
				get => PotionCount ?? default;
				set => PotionCount = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? SuperPotionCount { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("SuperPotionCount", IsNullable = false)]
			public int SuperPotionCountNullableXmlAccessor
			{
				get => SuperPotionCount ?? default;
				set => SuperPotionCount = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public int? HyperPotionCount { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HyperPotionCount", IsNullable = false)]
			public int HyperPotionCountNullableXmlAccessor
			{
				get => HyperPotionCount ?? default;
				set => HyperPotionCount = value;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public List<ItemReference<Item>> BattleItems { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("BattleItems", IsNullable = false)]
			[XmlArrayItem("ItemReference")]
			public ItemReference<Item>.Builder[] BattleItemsBuilder
			{
				get
				{
					if (BattleItems == null)
					{
						return Array.Empty<ItemReference<Item>.Builder>();
					}
					return BattleItems.Select(item=>new ItemReference<Item>.Builder(item)).ToArray();
				}
				set
				{
					BattleItems?.Clear();
					if (value == null)
					{
						return;
					}
					if (BattleItems == null)
					{
						BattleItems = new List<ItemReference<Item>>(value.Length);
					}
					ItemBuilder<ItemReference<Item>>.BuildList(value, BattleItems);
				}
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlIgnore]
			public List<ItemReference<Item>> OtherItems { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("OtherItems", IsNullable = false)]
			[XmlArrayItem("ItemReference")]
			public ItemReference<Item>.Builder[] OtherItemsBuilder
			{
				get
				{
					if (OtherItems == null)
					{
						return Array.Empty<ItemReference<Item>.Builder>();
					}
					return OtherItems.Select(item=>new ItemReference<Item>.Builder(item)).ToArray();
				}
				set
				{
					OtherItems?.Clear();
					if (value == null)
					{
						return;
					}
					if (OtherItems == null)
					{
						OtherItems = new List<ItemReference<Item>>(value.Length);
					}
					ItemBuilder<ItemReference<Item>>.BuildList(value, OtherItems);
				}
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<string> Badges { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Backpack"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (PotionCount is null)
					{
						return false;
					}
					if (SuperPotionCount is null)
					{
						return false;
					}
					if (HyperPotionCount is null)
					{
						return false;
					}
					if (BattleItems is null)
					{
						return false;
					}
					if (OtherItems is null)
					{
						return false;
					}
					if (Badges is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Backpack"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Backpack"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Backpack Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Backpack(DataId!.Value,
					PotionCount!.Value,
					SuperPotionCount!.Value,
					HyperPotionCount!.Value,
					BattleItems!,
					OtherItems!,
					Badges!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public record UnlikeAbility
	{
		public UnlikeAbility(string name,
			string description)
		{
			Name = name;
			Description = description;
		}
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Someone didn't document this item...
		/// </summary>
		public string Description { get; }
		[XmlType(nameof(UnlikeAbility), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : ItemBuilder<UnlikeAbility>
		{
			public Builder()
			{			}
			public Builder(UnlikeAbility unlikeAbility)
			{
				Name = unlikeAbility.Name;
				Description = unlikeAbility.Description;
			}
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlAttribute()]
			public string? Name { get; set; }
			/// <summary>
			/// Someone didn't document this item...
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Description { get; set; }
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="UnlikeAbility"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (Name is null)
					{
						return false;
					}
					if (Description is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="UnlikeAbility"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="UnlikeAbility"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override UnlikeAbility Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new UnlikeAbility(
					Name!,
					Description!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record Rival : BaseDataItem
	{
		public Rival(DataId dataId,
			ImageRef picture,
			Rank rank,
			string name,
			string age,
			string concept,
			Nature nature,
			string money,
			int hP,
			int willPoints,
			List<ItemReference<MonInstance>> party,
			string relationship,
			List<RivalBackground> backgrounds,
			RivalAttitudes attitude,
			List<UnlikeAbility> unlilkeAbilities) : base(dataId)
		{
			Picture = picture;
			Rank = rank;
			Name = name;
			Age = age;
			Concept = concept;
			Nature = nature;
			Money = money;
			HP = hP;
			WillPoints = willPoints;
			Party = new List<ItemReference<MonInstance>>(party).AsReadOnly();
			Relationship = relationship;
			Backgrounds = new List<RivalBackground>(backgrounds).AsReadOnly();
			Attitude = attitude;
			UnlilkeAbilities = new List<UnlikeAbility>(unlilkeAbilities).AsReadOnly();
		}

		public ItemReference<Rival> ItemReference => new ItemReference<Rival>(DataId, Name);

		/// <summary>
		/// Your Rival's better looking picture
		/// </summary>
		public ImageRef Picture { get; }
		/// <summary>
		/// Your Rival's Higher rank
		/// </summary>
		public Rank Rank { get; }
		/// <summary>
		/// Your Rival's Famous Name
		/// </summary>
		public string Name { get; }
		/// <summary>
		/// Your Rival's Believed Age
		/// </summary>
		public string Age { get; }
		/// <summary>
		/// Your Rival's Cooler Concept
		/// </summary>
		public string Concept { get; }
		/// <summary>
		/// Your Rival's Awesome Nature
		/// </summary>
		public Nature Nature { get; }
		/// <summary>
		/// Your Rival's Money (loaded btw)
		/// </summary>
		public string Money { get; }
		/// <summary>
		/// Your Rival's untouchable hit points
		/// </summary>
		public int HP { get; }
		/// <summary>
		/// Your Rival's seemingly endless willpoints
		/// </summary>
		public int WillPoints { get; }
		/// <summary>
		/// Your Rival's elite Pokemon party
		/// </summary>
		public IReadOnlyList<ItemReference<MonInstance>> Party { get; }
		/// <summary>
		/// Your relationship with your rival
		/// </summary>
		public string Relationship { get; }
		/// <summary>
		/// Your Rival's Backgrounds
		/// </summary>
		public IReadOnlyList<RivalBackground> Backgrounds { get; }
		/// <summary>
		/// Your Rival's Attitude towards you
		/// </summary>
		public RivalAttitudes Attitude { get; }
		/// <summary>
		/// Your Rival's Unlike-Abilities
		/// </summary>
		public IReadOnlyList<UnlikeAbility> UnlilkeAbilities { get; }
		[XmlType(nameof(Rival), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<Rival>
		{
			public Builder()
			{
				Party = new List<ItemReference<MonInstance>>(10);
				Backgrounds = new List<RivalBackground>(10);
				UnlilkeAbilities = new List<UnlikeAbility>(10);
			}
			public Builder(Rival rival)
			{
				DataId = rival.DataId;
				Picture = rival.Picture;
				Rank = rival.Rank;
				Name = rival.Name;
				Age = rival.Age;
				Concept = rival.Concept;
				Nature = rival.Nature;
				Money = rival.Money;
				HP = rival.HP;
				WillPoints = rival.WillPoints;
				Party = new List<ItemReference<MonInstance>>(rival.Party);
				Relationship = rival.Relationship;
				Backgrounds = new List<RivalBackground>(rival.Backgrounds);
				Attitude = rival.Attitude;
				UnlilkeAbilities = new List<UnlikeAbility>(rival.UnlilkeAbilities);
			}

			public ItemReference<Rival>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<Rival>(DataId.Value, Name);

			/// <summary>
			/// Your Rival's better looking picture
			/// </summary>
			[XmlIgnore]
			public ImageRef? Picture { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Picture", IsNullable = false)]
			public ImageRef.Builder? PictureXmlAccessor
			{
				get => Picture is null ? null : new ImageRef.Builder(Picture!);
				set => Picture = value?.Build();
			}

			/// <summary>
			/// Your Rival's Higher rank
			/// </summary>
			[XmlIgnore]
			public Rank? Rank { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Rank", IsNullable = false)]
			public Rank RankNullableXmlAccessor
			{
				get => Rank ?? default;
				set => Rank = value;
			}
			/// <summary>
			/// Your Rival's Famous Name
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Name { get; set; }
			/// <summary>
			/// Your Rival's Believed Age
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Age { get; set; }
			/// <summary>
			/// Your Rival's Cooler Concept
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Concept { get; set; }
			/// <summary>
			/// Your Rival's Awesome Nature
			/// </summary>
			[XmlIgnore]
			public Nature? Nature { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Nature", IsNullable = false)]
			public Nature NatureNullableXmlAccessor
			{
				get => Nature ?? default;
				set => Nature = value;
			}
			/// <summary>
			/// Your Rival's Money (loaded btw)
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Money { get; set; }
			/// <summary>
			/// Your Rival's untouchable hit points
			/// </summary>
			[XmlIgnore]
			public int? HP { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("HP", IsNullable = false)]
			public int HPNullableXmlAccessor
			{
				get => HP ?? default;
				set => HP = value;
			}
			/// <summary>
			/// Your Rival's seemingly endless willpoints
			/// </summary>
			[XmlIgnore]
			public int? WillPoints { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("WillPoints", IsNullable = false)]
			public int WillPointsNullableXmlAccessor
			{
				get => WillPoints ?? default;
				set => WillPoints = value;
			}
			/// <summary>
			/// Your Rival's elite Pokemon party
			/// </summary>
			[XmlIgnore]
			public List<ItemReference<MonInstance>> Party { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("Party", IsNullable = false)]
			[XmlArrayItem("ItemReference")]
			public ItemReference<MonInstance>.Builder[] PartyBuilder
			{
				get
				{
					if (Party == null)
					{
						return Array.Empty<ItemReference<MonInstance>.Builder>();
					}
					return Party.Select(item=>new ItemReference<MonInstance>.Builder(item)).ToArray();
				}
				set
				{
					Party?.Clear();
					if (value == null)
					{
						return;
					}
					if (Party == null)
					{
						Party = new List<ItemReference<MonInstance>>(value.Length);
					}
					ItemBuilder<ItemReference<MonInstance>>.BuildList(value, Party);
				}
			}
			/// <summary>
			/// Your relationship with your rival
			/// </summary>
			[XmlElement(IsNullable = false)]
			public string? Relationship { get; set; }
			/// <summary>
			/// Your Rival's Backgrounds
			/// </summary>
			[XmlElement(IsNullable = false)]
			public List<RivalBackground> Backgrounds { get; set; }
			/// <summary>
			/// Your Rival's Attitude towards you
			/// </summary>
			[XmlIgnore]
			public RivalAttitudes? Attitude { get; set; }
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlElement("Attitude", IsNullable = false)]
			public RivalAttitudes AttitudeNullableXmlAccessor
			{
				get => Attitude ?? default;
				set => Attitude = value;
			}
			/// <summary>
			/// Your Rival's Unlike-Abilities
			/// </summary>
			[XmlIgnore]
			public List<UnlikeAbility> UnlilkeAbilities { get; set; }
			
			[Browsable(false)]
			[DebuggerHidden]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[XmlArray("UnlilkeAbilities", IsNullable = false)]
			[XmlArrayItem("UnlikeAbility")]
			public UnlikeAbility.Builder[] UnlilkeAbilitiesBuilder
			{
				get
				{
					if (UnlilkeAbilities == null)
					{
						return Array.Empty<UnlikeAbility.Builder>();
					}
					return UnlilkeAbilities.Select(item=>new UnlikeAbility.Builder(item)).ToArray();
				}
				set
				{
					UnlilkeAbilities?.Clear();
					if (value == null)
					{
						return;
					}
					if (UnlilkeAbilities == null)
					{
						UnlilkeAbilities = new List<UnlikeAbility>(value.Length);
					}
					ItemBuilder<UnlikeAbility>.BuildList(value, UnlilkeAbilities);
				}
			}
			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="Rival"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					if (Picture is null)
					{
						return false;
					}
					if (Rank is null)
					{
						return false;
					}
					if (Name is null)
					{
						return false;
					}
					if (Age is null)
					{
						return false;
					}
					if (Concept is null)
					{
						return false;
					}
					if (Nature is null)
					{
						return false;
					}
					if (Money is null)
					{
						return false;
					}
					if (HP is null)
					{
						return false;
					}
					if (WillPoints is null)
					{
						return false;
					}
					if (Party is null)
					{
						return false;
					}
					if (Relationship is null)
					{
						return false;
					}
					if (Backgrounds is null)
					{
						return false;
					}
					if (Attitude is null)
					{
						return false;
					}
					if (UnlilkeAbilities is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="Rival"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="Rival"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override Rival Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new Rival(DataId!.Value,
					Picture!,
					Rank!.Value,
					Name!,
					Age!,
					Concept!,
					Nature!.Value,
					Money!,
					HP!.Value,
					WillPoints!.Value,
					Party!,
					Relationship!,
					Backgrounds!,
					Attitude!.Value,
					UnlilkeAbilities!);
			}
		}
	}
	[System.CodeDom.Compiler.GeneratedCode("BaseTypeBuilder.tt", "??")]
	public partial record EvolutionList : BaseDataItem
	{
		public EvolutionList(DataId dataId) : base(dataId)
		{
		}

		public ItemReference<EvolutionList> ItemReference => new ItemReference<EvolutionList>(DataId);

		[XmlType(nameof(EvolutionList), Namespace = "https://www.pokeroleproject.com/schemas/Structures.xsd")]
		public partial class Builder : DataItemBuilder<EvolutionList>
		{
			public Builder()
			{			}
			public Builder(EvolutionList evolutionList)
			{
				DataId = evolutionList.DataId;
			}

			public ItemReference<EvolutionList>? ItemReference => !DataId.HasValue ? null :
					new ItemReference<EvolutionList>(DataId.Value);

			/// <summary>
			/// Whether or not all of the required Properites of this instance are set to build a new
			/// <see cref="EvolutionList"/>. <see cref="Build"/> will throw an exception if this returns false.
			/// </summary>
			public override bool IsValid
			{
				get
				{
					if (DataId is null)
					{
						return false;
					}
					return true;
				}
			}
			/// <summary>
			/// Build and instance of <see cref="EvolutionList"/> from this Builder
			/// </summary>
			/// <returns>A new instance of <see cref="EvolutionList"/></returns>
			/// <exception cref="InvalidOperationException">If this method is called when not all required properties
			/// have been set</exception>
			public override EvolutionList Build(){
				if (!IsValid)
				{
					throw new InvalidOperationException("Not all required fields were set");
				}
				return new EvolutionList(DataId!.Value);
			}
		}
	}
}