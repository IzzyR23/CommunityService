using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
void Start()
{
    Debug.Log("Start is running");
}

   public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Void is read");

        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("if start");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("id end");
        }

        
    }
}
