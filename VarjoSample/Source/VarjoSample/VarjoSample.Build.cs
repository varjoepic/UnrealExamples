// Copyright Varjo Technologies Oy. All Rights Reserved.

using UnrealBuildTool;

public class VarjoSample : ModuleRules
{
	public VarjoSample(ReadOnlyTargetRules Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		PCHUsage = PCHUsageMode.NoPCHs;
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "VarjoHMD", "VarjoEyeTracker" });
	}
}
