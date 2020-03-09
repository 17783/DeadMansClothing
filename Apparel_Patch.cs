// Decompiled with JetBrains decompiler
// Type: DeadMansClothing.Apparel_Patch
// Assembly: DeadMansClothing, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null
// MVID: C3BD8A07-3584-40AF-B771-CAB455314BAC
// Assembly location: E:\RimWorld1-1-2566Win64\Mods\DeadMansClothing\Assemblies\DeadMansClothing.dll

using HarmonyLib;
using RimWorld;
using System.Reflection;

namespace DeadMansClothing
{
  [HarmonyPatch(typeof (Apparel))]
  [HarmonyPatch("Notify_PawnKilled")]
  internal class Apparel_Patch
  {
    private static void Postfix(Apparel __instance)
    {
      typeof (Apparel).GetField("wornByCorpseInt", BindingFlags.Instance | BindingFlags.NonPublic).SetValue((object) __instance, (object) false);
    }
  }
}
