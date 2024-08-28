using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 updatedPosition = gameObject.transform.position;
        updatedPosition.x += .001f;
        gameObject.transform.position = updatedPosition;
    }
}
