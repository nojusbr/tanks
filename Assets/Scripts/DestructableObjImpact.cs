using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class DestructableObjImpact : MonoBehaviour
{
    public GameObject breakVfx;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Tank"))
        {
            Instantiate(breakVfx, transform.position, quaternion.identity);
            Destroy(gameObject);
        }
    }
}
