using UnityEngine;
using UnityEngine.InputSystem;

public class ControlScript : MonoBehaviour
{
    private Rigidbody2D rb;   // посилання на компонент
    private InputAction moveAction;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        // Управління - аналіз реакції гравця
        // 1. Input - прямий доступ до пристроїв (клавіатура, миша, джойстик, тощо)
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     rb.AddForce(Vector2.up * 100f);
        // }
        // if (Input.GetKey(KeyCode.W))
        // {
        //     rb.AddForce(Vector2.up * 5f);
        // }

        // 2. Input Manager - поєднання різних способів управління по "осях"
        // float y = Input.GetAxis("Vertical");
        // rb.AddForce(5f * y * Vector2.up);

        // 3. Input System - поєднання осей у вектори
        rb.AddForce( 5f * moveAction.ReadValue<Vector2>() );
    }
}
