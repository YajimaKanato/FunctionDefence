using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 _orbit;

    float _speed;
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

        transform.position = SetOrbit(_delta, FunctionCalc.SecondDimensionFunc(_delta, c: 0));
    }

    Vector3 SetOrbit(float x, float y)
    {
        _orbit = new Vector3(x, y, 0);
        return _orbit;
    }
}
