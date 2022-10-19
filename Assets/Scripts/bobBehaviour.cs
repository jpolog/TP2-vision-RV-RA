using UnityEngine;
public class bobBehaviour : MonoBehaviour
{
    public GameObject fx;
    private AudioSource aud;
    public GameObject worldObject;

    void Start()
    {
        worldObject = GameObject.Find("World");
        aud = GameObject.Find("Audio").GetComponent<AudioSource>();
    }
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter
        worldObject.SendMessage("AddHit");
        if (other.tag == "Player")
        {
            Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
            if (aud)
            {
                aud.Play();
            }
        }
    }
}