using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{






    public float speed = 5f; // hahmon liikkumis nopeus
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized*speed*Time.deltaTime;

        transform.position += (Vector3)movement;
    }
}
