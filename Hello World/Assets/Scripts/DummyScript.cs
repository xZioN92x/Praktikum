using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyScript : MonoBehaviour
{
    public TestScript testScript;

    // Start is called before the first frame update
    void Start()
    {
        testScript.Test();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
