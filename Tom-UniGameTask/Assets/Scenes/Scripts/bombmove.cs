using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class bombmove : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    public float speed = 1f;




    void Update()
    {
        if (speed > 0)
        {
            transform.Translate(0f, 0f, .2f * speed * Time.deltaTime, Space.Self);
            speed -= 1.5f;
        }

        //transform.position += new Vector3(0f, 0f, .2f) * moveSpeed * Time.deltaTime; 

    }

}
