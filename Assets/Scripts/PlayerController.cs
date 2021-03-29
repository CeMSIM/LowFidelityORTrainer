using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;
    private float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.3f;
        rotationspeed = 1.0f;
 
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;

        float rotation = Input.GetAxis("Horizontal") * rotationspeed;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
