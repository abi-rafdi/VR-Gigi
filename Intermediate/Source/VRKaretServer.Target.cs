using UnrealBuildTool;

public class VRKaretServerTarget : TargetRules
{
	public VRKaretServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VRKaret");
	}
}
