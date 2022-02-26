using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Invoke("DropPlatform", 0.5f);
        Destroy(gameObject, 2f);
    }

    void DropPlatform()
    {
        rbody.isKinematic = false;
    }

}
