using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform player;
    public Collider trig;
    public float sens;
    public bool loc;
    private float mouseX;
    private float mouseY;
    private float rot = 0f;

    private void Start()
    {
        loc = true;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        rot -= mouseY;
        rot = Mathf.Clamp(rot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rot, 0, 0);
        player.Rotate(Vector3.up * mouseX);

        if (loc == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else { Cursor.lockState = CursorLockMode.None; }


    }
}
