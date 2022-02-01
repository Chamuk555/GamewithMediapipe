using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    // Start is called before the first frame update

        public int speed = 7; // Config speed
        public int jumpForce = 350; //Jump
        public float moveX; // Control X Line
        public bool isGround; // On the Ground ? T or F
        private Animator anim; // Input animator controller
        private Rigidbody2D rb;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal"); //Movement X Line
        rb.velocity = new Vector2(moveX*speed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
}
