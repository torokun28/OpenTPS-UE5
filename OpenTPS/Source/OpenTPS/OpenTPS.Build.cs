// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OpenTPS : ModuleRules
{
	public OpenTPS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"OpenTPS",
			"OpenTPS/Variant_Platforming",
			"OpenTPS/Variant_Platforming/Animation",
			"OpenTPS/Variant_Combat",
			"OpenTPS/Variant_Combat/AI",
			"OpenTPS/Variant_Combat/Animation",
			"OpenTPS/Variant_Combat/Gameplay",
			"OpenTPS/Variant_Combat/Interfaces",
			"OpenTPS/Variant_Combat/UI",
			"OpenTPS/Variant_SideScrolling",
			"OpenTPS/Variant_SideScrolling/AI",
			"OpenTPS/Variant_SideScrolling/Gameplay",
			"OpenTPS/Variant_SideScrolling/Interfaces",
			"OpenTPS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
