using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
