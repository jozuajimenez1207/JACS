using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipControls : MonoBehaviour
{
    public HealthBar healthBar;

    public Transform player;

    public FixedJoystick LeftJoystick;
    public FixedJoystick RightJoystick;
    public FixedJoystick HoverJoystick;

    public float forwardSpeed = 25f, strafeSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;
    private float forwardAcceleration = 2.5f, strafeAcceleration = 2f, hoverAcceleration = 2f;

    private float Hinput;
    private float Vinput;
    private float Xinput;
    private float Yinput;
    private float HoverInput;

    public float lookRateSpeed = 90f;

    protected float CameraAngle1;
    protected float CameraAngle2;
    protected float CameraAngleSpeed = 0.2f;

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - player.transform.position, Vector3.up);

        Hinput = LeftJoystick.input.x;
        Vinput = LeftJoystick.input.y;

        Xinput = RightJoystick.input.x;
        Yinput = RightJoystick.input.y;

        HoverInput = HoverJoystick.input.y;

        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, Vinput * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Hinput * strafeSpeed, strafeAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, HoverInput  * hoverSpeed, hoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += transform.right * activeStrafeSpeed * Time.deltaTime;
        transform.position += transform.up * activeHoverSpeed * Time.deltaTime;

        CameraAngle1 += Xinput * CameraAngleSpeed;
        CameraAngle2 += Yinput * CameraAngleSpeed;

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle1, Vector3.up) * Quaternion.AngleAxis(CameraAngle2, Vector3.right) * new Vector3(20, 8, 12);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (healthBar)
            {
                healthBar.TakeDamage(100f);
            }
        }
        else if (collision.gameObject.tag == "mountain")
        {
            if (healthBar)
            {
                healthBar.TakeDamage(10f);
            }
        }
    }
}
