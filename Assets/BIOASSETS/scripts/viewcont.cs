using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewcont : MonoBehaviour
{
    public GameObject pic;
    public void push()
    {
        if(pic.activeInHierarchy==true){
            pic.SetActive(false);
        }
        else{
            pic.SetActive(false);
        }
    }
}
