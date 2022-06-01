using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    if(Input.GetKeyDown(KeyCode.RightArrow))
    transform.position += Time.deltaTime * _moveSpeed * Vector3.right;

    if(Input.GetKeyDown(KeyCode.LeftArrow))
    transform.position += Time.deltaTime * _moveSpeed * Vector3.left;

    if(Input.GetKeyDown(KeyCode.UpArrow))
    transform.position += Time.deltaTime * _moveSpeed * Vector3.forward;

    if(Input.GetKeyDown(KeyCode.DownArrow))
    transform.position += Time.deltaTime * _moveSpeed * Vector3.back;

    if(Input.GetKeyDown(KeyCode.Escape))
    SceneManager.LoadScene("title screen");

    if(Input.GetKeyDown(KeyCode.R))
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 
    }
}
