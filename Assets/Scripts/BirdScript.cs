using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private float health;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        health = 100f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 250f);
        }
        this.transform.eulerAngles = new Vector3(0, 0, 3f * rb.linearVelocityY);

        health -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Food"))
        {
            GameObject.Destroy(other.gameObject);
            health = Mathf.Clamp(health + 10f, 0f, 100f);
            Debug.Log(health);
        }
    }
}
/* Д.З. Створення та знищення об'єктів:
 * Розробити додаткові префаби для "їжі", реалізувати їх взаємодію з персонажем.
 * Модифікувати алгоритми генерування нових об'єктів для випадкової появи
 * одного зі створених префабів (як окремий варіант - пропуск, нічого не з'являється)
 * ** Різні префаби дають різні ефекти (бали здоров'я)
 */
