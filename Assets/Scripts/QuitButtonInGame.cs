using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class QuitButtonInGame : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
