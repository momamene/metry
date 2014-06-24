using UnityEngine;
using System.Collections;

public class Const {
    public static readonly float size = GameObject.FindObjectOfType<Camera>().orthographicSize;
    public static readonly float AspectRatio = 1.5f;
    public static readonly Rect ViewportSize = new Rect(-size * AspectRatio, -size, size * AspectRatio * 2.0f, size * 2.0f);
}
