using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NPC" || collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
