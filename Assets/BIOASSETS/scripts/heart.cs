using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public Vector3 rotation;
    void Update()
    {
        this.transform.Rotate(rotation *1*Time.deltaTime);
    }
}
