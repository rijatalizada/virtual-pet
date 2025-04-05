using UnityEngine;
using TMPro;

public class PetNameManager : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void SavePetName()
    {
        string petName = nameInput.text;
        PlayerPrefs.SetString("PetName", petName);
        PlayerPrefs.Save();
    }
}
