// Decompiled with JetBrains decompiler
// Type: DeadMansClothing.ModInitializer
// Assembly: DeadMansClothing, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: C3BD8A07-3584-40AF-B771-CAB455314BAC
// Assembly location: E:\RimWorld1-1-2566Win64\Mods\DeadMansClothing\Assemblies\DeadMansClothing.dll

using HarmonyLib;
using System.Reflection;
using Verse;

namespace DeadMansClothing
{
  [StaticConstructorOnStartup]
  public class ModInitializer
  {
    static ModInitializer()
    {
            var harmony = new Harmony("de.hatti.rimworld.mod.deadmansclothing");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
  }
}
