using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterController control;
    public float speed;
    private Vector3 mov;
    private float movx;
    private float movy;

    // Update is called once per frame
    void Update()
    {
        movx = Input.GetAxis("Horizontal");
        movy = Input.GetAxis("Vertical");

        mov = transform.right * movx + transform.forward * movy;
        control.Move(mov * speed * Time.deltaTime);
    }
}
