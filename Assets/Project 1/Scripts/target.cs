using UnityEngine;

public class target : MonoBehaviour
{
    
    private Rigidbody targetRB;
    private GameManager gameManager;
    private float minSpeed = 10;
    private float maxSpeed = 10;
    private float maxTorque = 4;
    private float xRange = 4;
    private float ySpawnPos = -2;

    public GameObject FloatingScore;

    public ParticleSystem explosionParticle;
    public int pointValue;

    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        //upward force
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        //rotation
        targetRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        //start position 
        transform.position = RandomSpawnPos();
    }

    private void OnMouseDown()
    {
        if(gameManager.isGameActive)
        {
            ShowFloatingScore();
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
        
    }

    void ShowFloatingScore()
    {
        Instantiate(FloatingScore, transform.position, FloatingScore.transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
