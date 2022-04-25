using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerHealth);
    }

    public void SayHello()
    {
        Debug.Log("Hallo!");
        Debug.Log("Liebe Welt.");
    }
}
