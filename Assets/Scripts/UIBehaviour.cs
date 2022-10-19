using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    int nbHeads = 0;

    TMP_Text timerText;




    void Start()
    {
        headText = GameObject.Find("lblBob").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }
    void Update()
    {
    }

    public void AddHit()
    {
        nbHeads++;
        headText.text = "BobHeads: " + nbHeads;
    }

    IEnumerator TimerTick()
    {
        while (GameVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time :" + GameVariables.currentTime.ToString();
        }
        GameVariables.currentTime = GameVariables.allowedTime;
        // game over
        SceneManager.LoadScene("Level1BobHeads"); // le nom de votre scene
    }
}