using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTriggerDetection : MonoBehaviour
{
    public GameObject[] nextPoints;
    public bool istriggered;
    public AudioSource[] audioSources;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Marker")){
            transform.gameObject.GetComponent<Collider>().enabled = false;
            foreach (GameObject point in nextPoints) 
            {
                point.SetActive(true);
            }

            istriggered = true;
            SoundManager.Instance.PlayDing(audioSources[Random.Range(0, audioSources.Length - 1)]);
        }
    }
}
