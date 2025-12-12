using UnrealBuildTool;

public class VRKaretEditorTarget : TargetRules
{
	public VRKaretEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VRKaret");
	}
}
