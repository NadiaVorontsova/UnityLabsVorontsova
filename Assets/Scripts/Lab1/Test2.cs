using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Direction;
    public float MaxDistance = 5;

    private Rigidbody _rigidbody;
    private void Awake()
    {
        Cube.transform.position = Vector3.zero;
    }

    private void Start()
    {
        _rigidbody = Cube.GetComponent<Rigidbody>();
        _rigidbody.velocity = Direction;
    }

    private void FixedUpdate()
    {
        if (MaxDistance <= Cube.transform.position.magnitude)
            _rigidbody.velocity *= -1;
    }

}
