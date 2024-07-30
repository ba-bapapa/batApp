using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootRoot : MonoBehaviour
{
    [SerializeField] private GameObject eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(eventSystem);
        SceneManager.LoadScene("Title");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}