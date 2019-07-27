using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    //GameObject Cube;
    Material localMat;
    MeshRenderer mRender;

    bool inTrigger = false; 

    void Start()
    {
        mRender = GetComponent<MeshRenderer>();
        localMat = mRender.material;
    }

    // Update is called once per frame
    void Update()
    {
           if (inTrigger)
        {
            localMat.color = Color.green;
        }
           else
        {
            localMat.color = Color.black;
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    public void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
}
