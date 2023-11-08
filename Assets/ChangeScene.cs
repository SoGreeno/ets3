using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("middlewheel"))
        {
            SceneManager.LoadScene("Skarbówka");
        }
    }
}
