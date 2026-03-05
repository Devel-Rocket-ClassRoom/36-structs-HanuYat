using System;

struct ColorRGB
{
    public int R;
    public int G;
    public int B;

    public ColorRGB(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public int GetBrightness()
    {
        int brightness = (R + G + B) / 3;
        return brightness;
    }
}