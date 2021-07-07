
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInput : MonoBehaviour
{
    //public Transform player;
    public FixedJoystick LeftJoystick;
    //public FixedButton Button;
    public FixedTouchField TouchField;
    protected ThirdPersonUserControl Control;

    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;

    // Use this for initialization
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();

    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - player.transform.position, Vector3.up);
        //Control.m_Jump = Button.Pressed;
        Control.Hinput = LeftJoystick.input.x;
        Control.Vinput = LeftJoystick.input.y;

        

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(20, 8, 12);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colliding");
    }
}