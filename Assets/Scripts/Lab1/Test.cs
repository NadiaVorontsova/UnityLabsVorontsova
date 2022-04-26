using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Cube1;
    public Vector3 Direction;
    public float MaxDistance = 5;

    private float _sign = 1;

    private void Update()
    {
        Cube1.transform.position += _sign * Direction * Time.deltaTime;
        if (MaxDistance <= Cube1.transform.position.magnitude)
            _sign *= -1;
    }

}
