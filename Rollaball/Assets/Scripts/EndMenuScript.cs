using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuController : MonoBehaviour
{
    public void ReloadGame()
    {
        SceneManager.LoadScene("MiniGame");
    }

}
