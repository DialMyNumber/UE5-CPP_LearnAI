// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LearnAI : ModuleRules
{
	public LearnAI(ReadOnlyTargetRules Target) : base(Target)
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
			"LearnAI",
			"LearnAI/Variant_Platforming",
			"LearnAI/Variant_Platforming/Animation",
			"LearnAI/Variant_Combat",
			"LearnAI/Variant_Combat/AI",
			"LearnAI/Variant_Combat/Animation",
			"LearnAI/Variant_Combat/Gameplay",
			"LearnAI/Variant_Combat/Interfaces",
			"LearnAI/Variant_Combat/UI",
			"LearnAI/Variant_SideScrolling",
			"LearnAI/Variant_SideScrolling/AI",
			"LearnAI/Variant_SideScrolling/Gameplay",
			"LearnAI/Variant_SideScrolling/Interfaces",
			"LearnAI/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
