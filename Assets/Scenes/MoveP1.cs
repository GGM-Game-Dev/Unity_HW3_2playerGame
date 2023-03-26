using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveP1 : MonoBehaviour
{
    [SerializeField] private int speed = 5;

    [SerializeField] InputAction Wkey = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction Skey = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction Akey = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction Dkey = new InputAction(type: InputActionType.Button);

    public void OnEnable()
    {
        Wkey.Enable();
        Skey.Enable();
        Akey.Enable();
        Dkey.Enable();
    }

    public void OnDisable()
    {
        Wkey.Disable();
        Skey.Disable();
        Akey.Disable();
        Dkey.Disable();
    }
    private void Update()
    {
       
        if (Wkey.IsPressed())
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Skey.IsPressed())
        {
            transform.position += new Vector3(0, -1* speed * Time.deltaTime, 0);
        }
        if (Akey.IsPressed())
        {
            transform.position += new Vector3( -1* speed * Time.deltaTime,0, 0);
        }
        if (Dkey.IsPressed())
        {
            transform.position += new Vector3( speed * Time.deltaTime,0, 0);
        }

    }
}