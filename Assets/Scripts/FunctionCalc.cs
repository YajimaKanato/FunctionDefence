/// <summary>
/// ŠÖ”‚ğ•Û‘¶‚µ‚Ä‚¢‚éƒNƒ‰ƒX
/// </summary>
public static class FunctionCalc
{
    /// <summary>
    /// y=a*x+b
    /// </summary>
    /// <param name="x">•Ï”</param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static float FirstDimensionFunc(float x, float a = 1, float b = 1)
    {
        return a * x + b;
    }

    /// <summary>
    /// y=a*x^2+b*x+c
    /// </summary>
    /// <param name="x"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static float SecondDimensionFunc(float x, float a = 1, float b = 1, float c = 1)
    {
        return a * x * x + FirstDimensionFunc(x, b, c);
    }

    /// <summary>
    /// y=a*x^3+b*x^2+c*x+d
    /// </summary>
    /// <param name="x"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <param name="d"></param>
    /// <returns></returns>
    public static float ThirdDimensionFunc(float x, float a = 1, float b = 1, float c = 1, float d = 1)
    {
        return a * x * x * x + SecondDimensionFunc(x, b, c, d);
    }

    /// <summary>
    /// y=a*x^4+b*x^3+c*x^2+d*x+e
    /// </summary>
    /// <param name="x"></param>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <param name="d"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static float FourthDimensionFunc(float x, float a = 1, float b = 1, float c = 1, float d = 1, float e = 1)
    {
        return a * x * x * x * x + ThirdDimensionFunc(x, b, c, d, e);
    }


}
