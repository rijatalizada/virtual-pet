using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCycler : MonoBehaviour
{
    private string[] scenes = { "Kitchen", "LivingRoom", "Bathroom" };
    public bool isNext; // true for right arrow, false for left arrow

    public void SwitchScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        int currentIndex = System.Array.IndexOf(scenes, currentScene);

        if (currentIndex == -1) return;

        int newIndex = isNext ? currentIndex + 1 : currentIndex - 1;

        // Loop around
        if (newIndex >= scenes.Length) newIndex = 0;
        if (newIndex < 0) newIndex = scenes.Length - 1;

        SceneManager.LoadScene(scenes[newIndex]);
    }
}
