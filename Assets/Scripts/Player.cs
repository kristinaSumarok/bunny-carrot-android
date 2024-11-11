using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    public float moveSpeed;
    float hInput, vInput;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        hInput = joystick.Horizontal*moveSpeed;
        vInput = joystick.Vertical * moveSpeed;

        transform.Translate(hInput,vInput,0);
    }
}
