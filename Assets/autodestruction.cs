using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autodestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
   }

    void DestroyComponentDelayed()
    {
        Destroy(GetComponent<ConstantForce>(), 1);
    }

}
