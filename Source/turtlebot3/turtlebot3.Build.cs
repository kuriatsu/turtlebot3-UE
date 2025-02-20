// Copyright 2020-2021 Rapyuta Robotics Co., Ltd.

using UnrealBuildTool;

public class turtlebot3 : ModuleRules
{
    public turtlebot3(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        CppStandard = CppStandardVersion.Cpp17;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "rclUE", "RapyutaSimulationPlugins", "XmlParser", "GeometryScriptingEditor", "GeometryScriptingCore", "GeometryCore", "GeometryFramework" });

        PrivateDependencyModuleNames.AddRange(new string[] { });
    }
}
