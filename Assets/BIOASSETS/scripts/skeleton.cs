using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeleton : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Rotation;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Rotation*1*Time.deltaTime);
    }
}
