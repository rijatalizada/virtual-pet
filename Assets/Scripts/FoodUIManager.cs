using UnityEngine;

public class FoodUIManager : MonoBehaviour
{
    public GameObject foodPanel;
    public GameObject dimBackground; 

    public void ShowPanel()
    {
        dimBackground.SetActive(true); // Show dark background
        foodPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        foodPanel.SetActive(false);
        dimBackground.SetActive(false); // Hide dark background
    }
}
