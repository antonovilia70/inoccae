/// <summary>
/// The radii of each corner of the rounded rectangle.
/// </summary>
public struct CornerRadii
{
    public float TopLeft { get; set; }
    public float TopRight { get; set; }
    public float BottomLeft { get; set; }
    public float BottomRight { get; set; }

    public CornerRadii(float topLeft, float topRight, float bottomLeft, float bottomRight)
    {
        TopLeft = topLeft;
        TopRight = topRight;
        BottomLeft = bottomLeft;
        BottomRight = bottomRight;
    }
}

// Usage example:
var radii = new CornerRadii(10.0f, 15.0f, 5.0f, 20.0f);
