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

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
                Instantiate(prefab, frontOfPlayer, Quaternion.identity);
        }
    }

    void Update()
    {
        OnAttack();
    }
}
