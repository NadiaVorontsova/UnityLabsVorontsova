using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Direction;
    public float MaxDistance = 5;

    private Rigidbody _rigidbody;
    private void Awake()
    {
        Cube.transform.position = Vector3.one;
    }

    private void Start()
    {
        _rigidbody = Cube.GetComponent<Rigidbody>();
        _rigidbody.velocity = Direction;
        StartCoroutine(Fixed());
    }

    private IEnumerator Fixed()
    {
        var condition = new WaitUntil(() => MaxDistance <= Cube.transform.position.magnitude);
        while (true)
        {
            yield return condition;
            _rigidbody.velocity *= -1;
            yield return new WaitForFixedUpdate();
        }
    }

}
