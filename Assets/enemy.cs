using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class enemy : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    movement Ship;
    private void Start()
    {
        Ship = GameObject.Find("player").GetComponent<movement>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "lazer")
        { 
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        

    }
    private void Update()
    {
        transform.position = new Vector2 (
            transform.position.x,
            transform.position.y - speed * Time.deltaTime
        );

        if (transform.position.y < -5.5f)
        {
            Ship.hp = Ship.hp - 10;
            Destroy(this.gameObject);
        }

    }

    

}
