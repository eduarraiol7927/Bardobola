using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    SpriteRenderer sr
    BoxCollider2D bc;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
        
        transform.localScale = transform.localScale(0, 0, 0);
    }

    void Update()
    {
        if (GetKeyDown(KeyCode.LeftMouse))
    }
}
