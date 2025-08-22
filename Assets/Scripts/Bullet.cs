using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 _orbit;

    float _speed = 1;
    float _power;

    float _delta = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _delta += Time.deltaTime;
        /*
        SetSpeed(FunctionCalc.FirstDimensionFunc(_delta, b: 0));
        SetOrbit(FunctionCalc.CosFunc(_delta * 100 * _speed, 2), FunctionCalc.SinFunc(_delta * 100, 2));
        */
        transform.position = _orbit;
    }

    /// <summary>
    /// 軌道を決めるメソッド
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    void SetOrbit(float x, float y)
    {
        _orbit = new Vector3(x, y, 0);
    }

    /// <summary>
    /// 速度を決めるメソッド
    /// </summary>
    /// <param name="func"></param>
    void SetSpeed(float func)
    {
        _speed = func;
    }
}
