using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poschange : MonoBehaviour
{
    public GameObject target;
    public Vector3 newpos;
    public void change(){
        target.transform.position=newpos;
    }
}
