using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class conflict : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    public float speed=5f;


    

    void Update()
    {
        transform.Translate(0f, 0f, .2f * speed * Time.deltaTime,Space.Self );
        
        //transform.position += new Vector3(0f, 0f, .2f) * moveSpeed * Time.deltaTime; 

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag =="dusmen")
    //    {
    //        Health -= 10;
    //        Debug.Log("deydi");
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        
        //if (other.gameObject.tag == "dusmen")
        //{
        //    Health -= 10;
        //    Debug.Log("deydi");
        //}
    }

  

   
}
