using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Vector2 launchForce;
    bool isBallLaunched;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Launch") && !isBallLaunched)
        {
            isBallLaunched = true;
            rb.AddForce(new Vector2(100f, 200f));
            transform.parent = null;

        }

    }
}
