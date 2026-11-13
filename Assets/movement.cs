using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    [Header("Position Bounds")]
    [SerializeField] float minHor = -8.0f;
    [SerializeField] float maxHor = 8.0f;
    [SerializeField] float minVer = -4.5f;
    [SerializeField] float maxVer = 4.5f;
    [Space]
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

        Vector2 newPos = new Vector2 (
            Mathf.Clamp(transform.position.x + dir.x * speed * Time.deltaTime, minHor, maxHor),
            Mathf.Clamp(transform.position.y + dir.y * speed * Time.deltaTime, minVer, maxVer)
        );

        transform.position = newPos;
    }

    void shoot(InputAction.CallbackContext context)
    {
        Instantiate(laser, transform.position, Quaternion.identity);
    }
}