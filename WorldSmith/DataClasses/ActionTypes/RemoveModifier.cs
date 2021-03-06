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
	[EditorGrammar("Remove %ModifierName from %Target")]
	public partial class RemoveModifier : TargetedAction
	{
		[Category("Misc")]
		[Description("Modifier Name")]
		[DefaultValue("")]
		public string ModifierName
		{
			get;
			set;
		}

	}
}
