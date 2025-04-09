using UnityEngine;

public class FoodCategoryManager : MonoBehaviour
{
    public GameObject[] categoryPanels; // Meals, Drinks, etc.
    public GameObject menuPanel;        // Menu with food categories

    public void OpenCategory(int index)
    {
        foreach (GameObject panel in categoryPanels)
        {
            panel.SetActive(false);
        }

        if (index >= 0 && index < categoryPanels.Length)
        {
            categoryPanels[index].SetActive(true);
        }

        if (menuPanel != null)
        {
            menuPanel.SetActive(false);
        }
    }

    // 👇 Call this when pressing X in category panels
    public void BackToMenu()
    {
        foreach (GameObject panel in categoryPanels)
        {
            panel.SetActive(false);
        }

        if (menuPanel != null)
        {
            menuPanel.SetActive(true);
        }
    }
}
