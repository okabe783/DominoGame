using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoPush : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Domino"))
        {
            Debug.Log("触れた");
        }
    }
}
