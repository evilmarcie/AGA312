using TMPro;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private int pickups = 0;
    public TextMeshProUGUI pickupText;
    public GameObject winScreen;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pickup")
        {
            pickups++;
            Destroy(other.gameObject);
            Debug.Log("Pickups: " + pickups);
            pickupText.text = "points: " + pickups.ToString();
            if (pickups >= 5)
            {
                winScreen.SetActive(true);
                this.gameObject.GetComponent<FirstPersonMovement>().enabled = false;
            }
        }
    }

}
