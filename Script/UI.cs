using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    
    public void OnclickStart()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnclickSetting()
    {
        Debug.Log("¼³Á¤");
    }

    public void OnclickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
