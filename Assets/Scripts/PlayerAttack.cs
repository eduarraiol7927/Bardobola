using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public GameObject prefab;
    public GameObject player;
    
    void Start()
    {
        
    }

    void OnAttack()
    {   
        Vector3 frontOfPlayer = player.transform.position + transform.forward * 2;

        if (GetKeyDown(KeyCode.LeftMouse))
        {
                Instantiate(prefab, frontOfPlayer, Quaternion.Identity);
        }
    }

    void Update()
    {
        OnAttack();
    }
}
