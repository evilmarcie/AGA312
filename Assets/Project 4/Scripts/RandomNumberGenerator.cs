using UnityEngine;

public class RandomNumberGenerator : MonoBehaviour
{

    int randomNumber;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            GenerateRandomNumber();
        }        
    }

    private void GenerateRandomNumber
    {
        randomNumber = Random.Range 
    }
}
