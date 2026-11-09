using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    public int hp = 50;
    public GameObject laser;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        transform.position = new Vector2(0, -3);
        InputManager.instance().actions.player.Enable();
        InputManager.instance().actions.player.shoot.started += shoot;
    }
    void OnDisable()
    {
        InputManager.instance().actions.player.Disable();
        InputManager.instance().actions.player.shoot.started -= shoot;
    }


    // Update is called once per frame

    public float speed = 1.0f;
    void Update()
    {
        Vector2 dir = InputManager.instance().actions.player.move.ReadValue<Vector2>();

        if (transform.position.x > -9.5|| transform.position.y > -4.5 || transform.position.y < 4.5 || transform.position.x < 9.5)
        {
            transform.Translate(dir * speed * Time.deltaTime);
        }
    }

    void shoot(InputAction.CallbackContext context)
    {
        Instantiate(laser, transform.position, Quaternion.identity);
    }
}