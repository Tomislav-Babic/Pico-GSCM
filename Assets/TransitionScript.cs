using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    public static TransitionScript Instance;
    public GameObject player;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScene()
    {
        if (!SceneManager.GetSceneByName("Scena").isLoaded)
            SceneManager.LoadSceneAsync("Scena", LoadSceneMode.Additive);
    }
    public void AddScene2()
    {
        if (!SceneManager.GetSceneByName("Scena2").isLoaded)
            SceneManager.LoadSceneAsync("Scena2", LoadSceneMode.Additive);
    }
    public void AddScene3()
    {
        if (!SceneManager.GetSceneByName("Scena 3").isLoaded)
            SceneManager.LoadSceneAsync("Scena 3", LoadSceneMode.Additive);
    }
    public void RemoveScene()
    {
        if (SceneManager.GetSceneByName("Scena").isLoaded)
            SceneManager.UnloadSceneAsync("Scena", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
    public void RemoveScene2()
    {
        if (SceneManager.GetSceneByName("Scena2").isLoaded)
            SceneManager.UnloadSceneAsync("Scena2", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
    public void RemoveScene3()
    {
        if (SceneManager.GetSceneByName("Scena 3").isLoaded)
            SceneManager.UnloadSceneAsync("Scena 3", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
   
}
