using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField]float speed;
    
    void Update()
    {
        transform.Rotate (0,0,speed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Reactor")
                {
                    Debug.Log("hit");
                }
    }
}
