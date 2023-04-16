using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
 public Animator animator;
    private Vector2 movement;





    public float movementSpeed = 5f; // hahmon liikkumis nopeus
    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (movement != Vector2.zero) // (0, 0)
        {
            var xMovement = movement.x * movementSpeed * Time.deltaTime;
            this.transform.Translate(new Vector3(xMovement, 0), Space.World);

        }
        movement =  new Vector2(Input.GetAxis("Horizontal"), 0).normalized;
        animator.SetFloat("Speed", Mathf.Abs(movement.magnitude* movementSpeed));

        bool flipped = movement.x < 0;
        this.transform.rotation = Quaternion.Euler(new Vector3(0f, flipped ? 180f : 0f, 0f));
    }
    

        
}   
