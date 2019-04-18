

using UnrealBuildTool;
using System.Collections.Generic;

public class HP35Target : TargetRules
{
	public HP35Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "HP35" } );
	}
}
