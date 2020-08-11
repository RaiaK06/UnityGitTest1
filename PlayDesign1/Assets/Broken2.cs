using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken2 : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
