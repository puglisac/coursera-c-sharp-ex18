using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //move gameObject to mouse position on left click
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 newPosition = Input.mousePosition;
            newPosition.z = -Camera.main.transform.position.z;
            newPosition = Camera.main.ScreenToWorldPoint(newPosition);
            transform.position = newPosition;
        }
    }
}
