using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonControl : MonoBehaviour
{

    public void ReloadGameScene() {
        SceneManager.LoadScene(0);
        Debug.Log("reloadGameScene");
    }


}
