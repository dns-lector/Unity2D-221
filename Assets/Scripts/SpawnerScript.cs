using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] 
    private GameObject pipePrefab;
    private float pipeOffsetMax = 2.0f;

    [SerializeField] 
    private GameObject foodPrefab;
    private float foodOffsetMax = 4.5f;

    private float period = 4.0f;
    private float timeout;
    private float foodTimeout;

    void Start()
    {
        timeout = 0f;                  //  period
        foodTimeout = period * 1.5f;   //  |     |     |     |
                                       //           ^ period * 1.5
    }

    void Update()
    {
        timeout -= Time.deltaTime;
        if (timeout < 0)
        {
            timeout = period;
            SpawnPipe();
        }
        foodTimeout -= Time.deltaTime;
        if (foodTimeout < 0)
        {
            foodTimeout = period;
            SpawnFood();
        }
    }

    private void SpawnFood()
    {
        GameObject food = GameObject.Instantiate(foodPrefab);
        food.transform.position = this.transform.position +
            Random.Range(-foodOffsetMax, foodOffsetMax) * Vector3.up;
        food.transform.Rotate(0, 0, Random.Range(0, 360));
    }

    private void SpawnPipe()
    {
        GameObject pipe = GameObject.Instantiate(pipePrefab);
        pipe.transform.position = this.transform.position +
            Random.Range(-pipeOffsetMax, pipeOffsetMax) * Vector3.up;
    }
}
