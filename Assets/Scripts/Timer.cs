using TMPro;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator TimerTick()
    {
        timerText.text = "Time :" + GameVariables.currentTime.ToString();
        while (GameVariables.currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time :" + GameVariables.currentTime.ToString();
        }
        GameVariables.currentTime = GameVariables.allowedTime;
        // game over
        SceneManager.LoadScene("terrain"); // le nom de votre scene
    }
}
