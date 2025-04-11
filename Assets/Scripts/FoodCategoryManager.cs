using UnityEngine;

public class FoodCategoryManager : MonoBehaviour
{
    public GameObject menuPanel;          // The main category panel (with Meals, Drinks, etc.)
    public GameObject[] categoryPanels;   // All category panels

    public void OpenCategoryPanel(int index)
    {
        menuPanel.SetActive(false); // hide main menu

        for (int i = 0; i < categoryPanels.Length; i++)
        {
            categoryPanels[i].SetActive(i == index); // show selected, hide others
        }
    }

    public void CloseCategoryPanel()
    {
        // hide all food panels
        foreach (GameObject panel in categoryPanels)
        {
            panel.SetActive(false);
        }

        // show the main category panel again
        menuPanel.SetActive(true);
    }
}
