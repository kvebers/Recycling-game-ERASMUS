using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}