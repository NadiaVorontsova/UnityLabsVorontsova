using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Vector3 Size;
    public Vector3 Rotation;

    private void Update()
    {
        if (this.gameObject.transform.localScale.x < Size.x) 
        {
            this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x+0.01f, 
                this.gameObject.transform.localScale.y+0.01f);
        }
        if (this.gameObject.transform.rotation.z < Rotation.z)
        {
            this.gameObject.transform.Rotate(0,0,this.gameObject.transform.localScale.z + 0.07f);
        }
    }

}
