using System.Runtime.InteropServices;
using FFXIVClientStructs.FFXIV.Component.GUI;
using GatherBuddy.Enums;

namespace GatherBuddy.SeFunctions;

[StructLayout(LayoutKind.Explicit)]
public struct SpearfishWindow
{
    [FieldOffset(0)]
    public AtkUnitBase Base;

    [StructLayout(LayoutKind.Explicit)]
    public struct Info
    {
        [FieldOffset(0x00)]
        public bool Available;

        [FieldOffset(0x08)]
        public bool InverseDirection;

        [FieldOffset(0x09)]
        public bool GuaranteedLarge;

        [FieldOffset(0x0A)]
        public SpearfishSize Size;

        [FieldOffset(0x0C)]
        public SpearfishSpeed Speed;
    }

    [FieldOffset(0x29C)]
    public Info Fish1;

    [FieldOffset(0x2B8)]
    public Info Fish2;

    [FieldOffset(0x2D4)]
    public Info Fish3;


    public unsafe AtkResNode* FishLines
        => Base.UldManager.NodeList[3];

    public unsafe AtkResNode* Fish1Node
        => Base.UldManager.NodeList[15];

    public unsafe AtkResNode* Fish2Node
        => Base.UldManager.NodeList[16];

    public unsafe AtkResNode* Fish3Node
        => Base.UldManager.NodeList[17];
}