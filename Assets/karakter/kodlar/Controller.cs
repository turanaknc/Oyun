using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float inputX;
    float inputY;

    public Transform Model;

    Animator Anim;

    Vector3 StickDirection;


    Camera mainCam;

    public float damp;

    [Range(1,20)]
    public float rotationSpeed;


    void Start()
    {
        Anim = GetComponent<Animator>();
        mainCam = Camera.main;
    }

    private void LateUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        StickDirection =new Vector3 (inputX, 0, inputY);

        ÝnputMove();
        ÝnputRotation();
    }
    void ÝnputMove()
    {
        if (Anim)
        {
            Vector3 newPosition = transform.position;
            newPosition.z += Anim.GetFloat("speed") * Time.deltaTime;
            transform.position = newPosition;
        }
        Anim.SetFloat("speed" , Vector3.ClampMagnitude(StickDirection, 1).magnitude, damp , Time.deltaTime * 10);

    }
    void ÝnputRotation()
    {
        Vector3 rot0fset = mainCam.transform.TransformDirection(StickDirection);
        rot0fset.y = 0;

        Model.forward = Vector3.Slerp(Model.forward, rot0fset, Time.deltaTime * rotationSpeed);
    }
}
