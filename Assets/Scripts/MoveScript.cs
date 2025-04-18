using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // [SerializeField]
    private float speed = 1.5f;

    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector3.left, Space.World);
    }
}
/* Використовуючи [SerializeField] підібрати мінімальну та максимальну
 * швидкість руху елементів для складного та простого режимів гри.
 * Зробити аналогічні дії з множником сили для управління персонажем.
 */