/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("No Editor Grammar set")]
	public partial class TrackingProjectile : BaseAction
	{
		[Category("Misc")]
		[Description("bool")]
		[DefaultValue("")]
		public string Dodgeable
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("bool")]
		[DefaultValue("")]
		public string ProvidesVision
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string VisionRadius
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("Effect Name")]
		[DefaultValue("")]
		public string EffectName
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string MoveSpeed
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("?")]
		[DefaultValue("")]
		public string SourceAttachment
		{
			get;
			set;
		}

	}
}
