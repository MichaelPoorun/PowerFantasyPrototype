using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonCounter : MonoBehaviour
{
    public int pressCount = 0;
    public float timer = 15f;
    private bool isTimerRunning = true;

    public TMP_Text countText; 
    public TMP_Text timerText; 
    public TMP_Text messageText; 

    public string winSceneName = "WinScene";
    public string winSceneName2 = "WinScene2";
    public string winSceneName3 = "WinScene3";
    public string loseSceneName = "LoseScene";

    void Update()
    {

        if (isTimerRunning)
        {

            timer -= Time.deltaTime;
            if (timerText != null)
                timerText.text = Mathf.Ceil(timer).ToString();

            if (Input.GetKeyDown(KeyCode.Space))
            {
                pressCount++;
                transform.position += new Vector3(0, 0.01f, 0);
                //if (countText != null)
                    //countText.text = "Presses: " + pressCount.ToString(); //Test if count works

                UpdateMessage();
            }

            if (timer <= 0)
            {

                isTimerRunning = false;
                CheckWinCondition();

            }
        }
    }

    void UpdateMessage()
    {

        if (messageText != null)
        {
            if (pressCount == 25)
            {
                messageText.text = "Powerful";
            }

            else if (pressCount == 50)
            {
                messageText.text = "Mighty!";
            }

            else if (pressCount == 75)
            {
                messageText.text = "Herculean!";
            }

            else if (pressCount == 100)
            {
                messageText.text = "Godly!";
            }
        }
    }

    void CheckWinCondition()
    {

        if (pressCount >= 100)
        {
            SceneManager.LoadScene(winSceneName);
        }

        else if(pressCount < 100 || pressCount >= 75) 
        {
            SceneManager.LoadScene(winSceneName2);
        }

        else if (pressCount < 75 || pressCount >= 50)
        {
            SceneManager.LoadScene(winSceneName3);
        }

        else if (pressCount < 50 || pressCount >= 25)
        {
            SceneManager.LoadScene(loseSceneName);
        }
    }
}
