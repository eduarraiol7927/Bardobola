using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public GameObject prefab;
    public GameObject FirePoint;
    

    void OnAttack(InputValue value)
    {   
        Vector2 firePoint = FirePoint.transform.position;

        if (value.isPressed)
        {
            GameObject instanciado = Instantiate(prefab, firePoint, Quaternion.identity);

            Destroy(instanciado, 3f);
        }
    }
}
