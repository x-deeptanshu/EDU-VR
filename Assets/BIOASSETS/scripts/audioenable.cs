using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioenable : MonoBehaviour
{
    public GameObject g1;
    public GameObject g2;
    public void shift(){
        if(g1.activeInHierarchy==true&&g2.activeInHierarchy==false){
            g1.SetActive(false);
            g2.SetActive(true);

        }
        else{
            g1.SetActive(true);
            g2.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
