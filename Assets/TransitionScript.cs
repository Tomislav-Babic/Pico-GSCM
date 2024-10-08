using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNeverWillTriggerContainer() {

        if (!SceneManager.GetSceneByName("sceneName").isLoaded)
            SceneManager.LoadSceneAsync("sceneName", LoadSceneMode.Additive);

        if (SceneManager.GetSceneByName("sceneName").isLoaded)
            SceneManager.UnloadSceneAsync("sceneName", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
}
