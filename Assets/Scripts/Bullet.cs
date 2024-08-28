using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 thrust;
    public Quaternion heading;

    // Start is called before the first frame update
    void Start()
    {
        // travel straight in the X-axis
        thrust.x = 400.0f;

        // do not passively decelerate
        GetComponent<Rigidbody>().drag = 0;

        // set the direction it will travel in
        GetComponent<Rigidbody>().MoveRotation(heading);

        // apply thrust once, no need to apply it again since
        // it will not decelerate
        GetComponent<Rigidbody>().AddRelativeForce(thrust);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.collider;
        if (collider.CompareTag("Asteroid"))
        {
            Asteroid roid = collider.gameObject.GetComponent<Asteroid>();

            // let the other object handle its own death throes
            roid.Die();

            // Destroy the Bullet which collided with the Asteroid
            Destroy(gameObject);
        } else
        {
            // if we collided with something else, print tag of other thing
            Debug.Log("Collided with " + collider.tag);
        }
    }
}
