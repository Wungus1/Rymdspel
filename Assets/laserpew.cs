using UnityEngine;

public class laserpew : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float despawnPos = 10.0f;
    float yPos = 0.0f;

    private void Start()
    {
        yPos = transform.position.y;
    }

    void Update()
    {
        yPos += speed * Time.deltaTime;
        transform.position = new Vector2(transform.position.x, yPos);

        if (transform.position.y > despawnPos)
            Destroy(gameObject);
    }
}
