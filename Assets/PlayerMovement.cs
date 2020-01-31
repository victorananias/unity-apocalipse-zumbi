using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var aixosX = Input.GetAxis("Horizontal");
        var aixosY = Input.GetAxis("Vertical");
        
        var newPosition = new Vector3(aixosX, 0, aixosY);
        
        transform.Translate(newPosition * Time.deltaTime * PlayerSpeed);
    }
}
