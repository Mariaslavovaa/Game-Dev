using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float Speed = 60f;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    /* private void FixedUpdate()
    {
        rbody.velocity = new Vector2(2f, 0f);
    }
    */


    // Update is called once per frame
    void Update()
    {
        //vertical move
        if (Input.GetKey(KeyCode.UpArrow) && gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            rbody.AddForce(new Vector3(0, 50f, 0));
            //this.transform.Translate(0, 0.2f, 0);
        }

        //horizontal move
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbody.AddForce(new Vector3(-2, 0, 0));
            //this.transform.Translate(-0.02f, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rbody.AddForce(new Vector3(2, 0, 0));
            //this.transform.Translate(0.02f, 0, 0);
        }
        
        //fall
        if (this.transform.position.y < -2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        this.transform.parent = col.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        this.transform.parent = null;
    }

}


