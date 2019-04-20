
using UnrealBuildTool;

public class ExtraCamWindow : ModuleRules
{
	public ExtraCamWindow(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;


        PublicIncludePaths.AddRange(
            new string[] {
            }
            );


        PrivateIncludePaths.AddRange(
            new string[] {
            }
            );

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
            }
            );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "Projects",
                "InputCore",
                //"UnrealEd",
                //"LevelEditor",
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "RHI", // For working with Back buffer and render targets
                "Renderer",
                "UMG"
            }
            );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {

            }
            );

    }
}
