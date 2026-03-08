// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class TPSMecha : ModuleRules
{
	public TPSMecha(ReadOnlyTargetRules Target) : base(Target)
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
			"TPSMecha",
			"TPSMecha/Variant_Platforming",
			"TPSMecha/Variant_Platforming/Animation",
			"TPSMecha/Variant_Combat",
			"TPSMecha/Variant_Combat/AI",
			"TPSMecha/Variant_Combat/Animation",
			"TPSMecha/Variant_Combat/Gameplay",
			"TPSMecha/Variant_Combat/Interfaces",
			"TPSMecha/Variant_Combat/UI",
			"TPSMecha/Variant_SideScrolling",
			"TPSMecha/Variant_SideScrolling/AI",
			"TPSMecha/Variant_SideScrolling/Gameplay",
			"TPSMecha/Variant_SideScrolling/Interfaces",
			"TPSMecha/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
