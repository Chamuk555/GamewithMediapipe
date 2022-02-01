// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ninja_Controller : MonoBehaviour
// {
//     public int speed = 8; //Config speed
//     public int jumpForce = 250; // jump
//     public float moveX;
//     public bool isGround; 
//     private Animator anim;   //animator controller
//     private Rigidbody2D rb;

//     // Start is called before the first frame update
//     void Start()
//     {
//         anim = GetComponent<Animator>();
//         rb = GetAxis<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         moveX = Input.GetAxis("Horizontal"); // X Line
//         rb.velocity = new Vector2(moveX*speed,gameObject.GetComponent<Rigidbody2D>().velocity);

//     }
// }