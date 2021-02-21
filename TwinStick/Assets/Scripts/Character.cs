using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float health = 100;
    public float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CheckInput()
    {
        if (Input.GetAxis("Horizontal")>0.1f)
        {

        }

        if (Input.GetAxis("Vertical") > 0.1f)
        {

        }


    }
}
