using UnityEngine;

public class WedgeRotate : MonoBehaviour
{
    [SerializeField]float speed;
    
    void Update()
    {
        transform.Rotate (0,0,speed*Time.deltaTime);
    }
}
