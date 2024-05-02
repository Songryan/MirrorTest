using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EPlayerColor
{
    Red, Blue, Green,
    Pink, Orange, Yellow,
    Black, White, Purple,
    Brown, Cyan, Lime
}

public class PlayerColor
{
    private static List<Color> colors = new List<Color>()
    {
        new Color(1f, 0f, 0f),
        new Color(0.1f, 0.1f, 1f),
        new Color(0f, 0.6f, 0f),
        new Color(1f, 0.3f, 0.9f),
        new Color(1f, 0.4f, 0f),
        new Color(1f, 0.9f, 0.1f),
        new Color(0.2f, 0.2f, 0.2f),
        new Color(0.9f, 1f, 1f),
        new Color(0.6f, 0f, 0.6f),
        new Color(0.7f, 0.2f, 0f),
        new Color(0f, 1f, 1f),
        new Color(0.1f, 1f, 0.1f)
    };

    public static Color GetColor(EPlayerColor playerColor) { return colors[(int)playerColor]; }
    public static Color Red(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Red]; }
    public static Color Blue(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Blue]; }
    public static Color Green(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Green]; }
    public static Color Pink(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Pink]; }
    public static Color Orange(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Orange]; }
    public static Color Yellow(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Yellow]; }
    public static Color Black(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Black]; }
    public static Color White(EPlayerColor playerColor) { return colors[(int)EPlayerColor.White]; }
    public static Color Purple(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Purple]; }
    public static Color Brown(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Brown]; }
    public static Color Cyan(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Cyan]; }
    public static Color Lime(EPlayerColor playerColor) { return colors[(int)EPlayerColor.Lime]; }
}
