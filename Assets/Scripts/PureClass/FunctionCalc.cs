using UnityEngine;

/// <summary>
/// �֐���ۑ����Ă���N���X
/// </summary>
public static class FunctionCalc
{
    /// <summary>
    /// y=a*x+b
    /// </summary>
    /// <param name="x">�ϐ�</param>
    /// <param name="a">�萔</param>
    /// <param name="b">�萔</param>
    /// <returns></returns>
    public static float FirstDimensionFunc(float x, float a = 1, float b = 1)
    {
        return a * x + b;
    }

    /// <summary>
    /// y=a*x^2+b*x+c
    /// </summary>
    /// <param name="x">�ϐ�</param>
    /// <param name="a">�萔</param>
    /// <param name="b">�萔</param>
    /// <param name="c">�萔</param>
    /// <returns></returns>
    public static float SecondDimensionFunc(float x, float a = 1, float b = 1, float c = 1)
    {
        return a * x * x + FirstDimensionFunc(x, b, c);
    }

    /// <summary>
    /// y=a*x^3+b*x^2+c*x+d
    /// </summary>
    /// <param name="x">�ϐ�</param>
    /// <param name="a">�萔</param>
    /// <param name="b">�萔</param>
    /// <param name="c">�萔</param>
    /// <param name="d">�萔</param>
    /// <returns></returns>
    public static float ThirdDimensionFunc(float x, float a = 1, float b = 1, float c = 1, float d = 1)
    {
        return a * x * x * x + SecondDimensionFunc(x, b, c, d);
    }

    /// <summary>
    /// y=a*x^4+b*x^3+c*x^2+d*x+e
    /// </summary>
    /// <param name="x">�ϐ�</param>
    /// <param name="a">�萔</param>
    /// <param name="b">�萔</param>
    /// <param name="c">�萔</param>
    /// <param name="d">�萔</param>
    /// <param name="e">�萔</param>
    /// <returns></returns>
    public static float FourthDimensionFunc(float x, float a = 1, float b = 1, float c = 1, float d = 1, float e = 1)
    {
        return a * x * x * x * x + ThirdDimensionFunc(x, b, c, d, e);
    }

    /// <summary>
    /// �T�C���֐�
    /// </summary>
    /// <param name="theta">�ϐ�</param>
    /// <param name="a">�萔</param>
    /// <returns></returns>
    public static float SinFunc(float theta, float a = 1)
    {
        return a * Mathf.Sin(theta * Mathf.Deg2Rad);
    }

    /// <summary>
    /// �R�T�C���֐�
    /// </summary>
    /// <param name="theta">�ϐ�</param>
    /// <param name="a">�萔</param>
    /// <returns></returns>
    public static float CosFunc(float theta, float a = 1)
    {
        return a * Mathf.Cos(theta * Mathf.Deg2Rad);
    }
}
