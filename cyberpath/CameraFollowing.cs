using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading; 

public class camera : MonoBehaviour
{
    public float k;
    // Start is called before the first frame update
    void Start()
    {
        k=1;
        transform.localPosition=new Vector3(0,k,-3*k);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition=new Vector3(0,k,-3*k);
        if(Keyboard.current.zKey.isPressed)
        {
            k+=0.1f;
            Thread.Sleep(100);
        }
        if(Keyboard.current.xKey.isPressed&&k>=1)
        {
            k-=0.1f;
            Thread.Sleep(100);
        }
       // float x0=GameObject.Find("Cube").GetComponent<hello>().x;
       // float y0=GameObject.Find("Cube").GetComponent<hello>().y;
       // float z0=GameObject.Find("Cube").GetComponent<hello>().z;
       // float x1=GameObject.Find("Cube").GetComponent<hello>().xx;
       // float y1=GameObject.Find("Cube").GetComponent<hello>().yy;
       // float z1=GameObject.Find("Cube").GetComponent<hello>().zz;
    
    }
   
}
