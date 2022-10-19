using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject thePlayer;
    public Transform teleportTarget;
    int enemiesLeft = 0;
    bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("BobHead");
        enemiesLeft = enemies.Length;
        if(enemiesLeft == 0 && !win)
        {
            win = true;
            thePlayer.transform.position = teleportTarget.transform.position;
        }
    }
}
