using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMove : MonoBehaviour
{

    public Rigidbody2D rb;
    bool moveleft = false;

    // Start is called before the first frame update
    void MoveControls()
    {
        if (input.GetKey(KeyCode.LeftArrow))
        {
            moveleft = true;
        }
        else
        {
            moveleft = false;
        }
        moveRight = Input.GetKey(KeyCode.RightArrow);
    }

    // Update is called once per frame
    void Update()
    {
        MoveControls();
    }

    private void FixedUpdate()
    {
        if (moveleft == true) 
        rb.AddForce(Vector2.Left) = ;
    }

}
