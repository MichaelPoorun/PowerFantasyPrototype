using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainScene : MonoBehaviour
{

    public string mainSceneName = "MainScene";

    void Start()
    {

        Button button = GetComponent<Button>();

        if (button != null)
        {

            button.onClick.AddListener(LoadScene);

        }

    }

    void LoadScene()
    {

        SceneManager.LoadScene(mainSceneName);

    }
}
