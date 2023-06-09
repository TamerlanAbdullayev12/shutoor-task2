using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    
    
    

    public float explosionRadius = 5f; 
    public float explosionForce = 100f;
    private bool hasExploded = false;
    

    void Start()
    {
        StartCoroutine(Bombe());
        

    }

    void Update()
    {
       
    }


   private IEnumerator Bombe()
    {
        yield return new WaitForSeconds(2f);
        if (!hasExploded)
        {
            hasExploded = true;
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
            foreach (Collider collider in colliders)
            {
                Rigidbody rb = collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(explosionForce * 2f, transform.position, explosionRadius);
                }

                Destroy(gameObject);
            }
        }

    }
}
