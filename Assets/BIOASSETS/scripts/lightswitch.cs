using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    public Light mylight;
    // Start is called before the first frame update
    void Start()
    {
        int a=5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Togglelight()
    {
        if(mylight.enabled==true){
            mylight.enabled=false;
        }
        else{
            mylight.enabled=true;
        }
    }
}
