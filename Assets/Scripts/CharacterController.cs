using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Animator animator;
    public float rotationSpeed = 1;
    public int smooth = 180;
    private float mouseX, mouseY;
    public float speed = 2;
    private float ver;

    void Start()
    {
        animator = GetComponent<Animator>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update () {
        PlayerMovement ();
        PlayerRotation ();
        Walk();
    }

    void PlayerMovement () {
        ver = Input.GetAxis ("Vertical");
        Vector3 playerMovement = new Vector3 (0f, 0f, ver) * speed * Time.deltaTime;
        transform.Translate (playerMovement, Space.Self);
    }

    void PlayerRotation () {
        mouseX += Input.GetAxis ("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis ("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp (mouseY, -10, 60);

        this.transform.rotation = Quaternion.Euler (0, mouseX, 0);
    }

    void Walk(){
        animator.SetFloat("isWalk", ver);
    }
}