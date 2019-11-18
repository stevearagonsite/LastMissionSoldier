// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LastMissionSoldierTarget : TargetRules
{
	public LastMissionSoldierTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "LastMissionSoldier" } );
	}
}
