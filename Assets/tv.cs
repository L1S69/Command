using UnityEngine;

public class tv : MonoBehaviour
{
    public void On(Color col, Vector2 pos)
    {
        GetComponent<SpriteRenderer>().color = col;
        transform.position = new Vector2(transform.position.x + pos.x,transform.position.y +pos.y);
        
    }

    public void Off(Color col, Vector2 pos)
    {
        GetComponent<SpriteRenderer>().color = col;
        transform.position = new Vector2(transform.position.x + pos.x*(-1),transform.position.y +pos.y*(-1));
    }
}
