using UnrealBuildTool;

public class VRKaretTarget : TargetRules
{
	public VRKaretTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VRKaret");
	}
}
