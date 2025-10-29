using UnityEngine;

public class FloatingScore : MonoBehaviour
{

    public float DestroyTime = 1f;

    void Start()
    {
        Destroy(gameObject, DestroyTime);
    }

    
}
