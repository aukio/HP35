

using UnrealBuildTool;
using System.Collections.Generic;

public class HP35EditorTarget : TargetRules
{
	public HP35EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "HP35" } );
	}
}
