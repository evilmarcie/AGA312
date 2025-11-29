using UnityEngine;
using TMPro;
using TMPro.EditorUtilities;

public class RandomNumberGenerator : MonoBehaviour
{

    public int randomNumber;
    [SerializeField] TMP_Text displayNumber;

    void Start()
    {
        GenerateRandomNumber();
    }

    public void GenerateRandomNumber()
    {
        randomNumber = Random.Range(0, 999);
        displayNumber.text = randomNumber.ToString();
    }
}
