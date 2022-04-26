using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject Cube;
    public Vector3 Size;
    public Vector3 Rotation;

    private void Update()
    {
        if (Cube.transform.localScale.x < Size.x) 
        {
            Cube.transform.localScale = new Vector3(Cube.transform.localScale.x+0.01f,
                Cube.transform.localScale.y+0.01f);
        }
        if (Cube.transform.rotation.z < Rotation.z)
        {
            Cube.transform.Rotate(0,0, Cube.transform.localScale.z + 0.07f);
        }
    }

}
