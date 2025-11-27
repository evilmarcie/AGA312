using Unity.VisualScripting;
using UnityEngine;

public class CompareValue : MonoBehaviour
{
    public GameObject numberGenerator_1;
    public GameObject numberGenerator_2;

     int value_1;
     int value_2;

    void Start()
    {
        
        getValues();
        Debug.Log(Mathf.Max(value_1, value_2));
    }

    void getValues()
    {
        value_1 = 
        value_1 = 0;
    }
}

