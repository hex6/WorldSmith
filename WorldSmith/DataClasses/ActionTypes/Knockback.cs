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
	public partial class Knockback : TargetedAction
	{
		[Category("Misc")]
		[Description("probably null")]
		[DefaultValue("")]
		public string Center
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string Distance
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("bool")]
		[DefaultValue("")]
		public string IsFixedDistance
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string Height
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("int")]
		[DefaultValue("")]
		public string Duration
		{
			get;
			set;
		}

	}
}
