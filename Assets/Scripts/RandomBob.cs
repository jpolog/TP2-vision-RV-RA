using UnityEngine;
public class RandomBob : MonoBehaviour
{
    public GameObject prefab;
    public int nbObjects = 10;
    public float minX = -25f;
    public float maxX = 25f;
    public float minZ = -25f;
    public float maxZ = 25f;
    public float y = 0.5f;
    void Start()
    {
        for (int i = 0; i < nbObjects; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(minX, maxX), y, Random.Range(minZ, maxZ));
            Instantiate(prefab, randomPos, Quaternion.identity);
        }
    }
    void Update()
    {
    }
}