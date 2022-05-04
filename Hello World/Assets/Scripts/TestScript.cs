using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private Rigidbody rigidbody;

    // Start is called before the first frame update

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Gate"))
        {
            Debug.Log("Das Tor wurde betreten!");
        }
    }

    public void Test()
    {
        Debug.Log("Hello!");
    }

    //test
  
}
