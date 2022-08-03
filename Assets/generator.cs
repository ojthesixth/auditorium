using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
 /*   public int counter = 0;
    public int rate = 60; */
    void Start()
    {
        transform.position = Random.insideUnitCircle * 5;
    }

  /*  Vector2 v = Random.insideUnitCircle;
        v = Random.insideUnitCircle;
  */

    void Update()
    {
       
    }
}
