using UnityEngine;
using UnityEngine.SceneManagement;

public class CylinderObstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndMenu");
        }
    }
}
