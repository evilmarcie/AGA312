using UnityEngine;
using TMPro;
using TMPro.EditorUtilities;

public class RandomNumberGenerator : MonoBehaviour
{

    [SerializeField]int randomNumber;
    [SerializeField] TMP_Text displayNumber;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            GenerateRandomNumber();
        }        
    }

    public void GenerateRandomNumber()
    {
        randomNumber = Random.Range(0, 999);
        displayNumber.text = randomNumber.ToString();
    }
}
