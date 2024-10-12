using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExitLoad3AndUnload2 : MonoBehaviour
{
    public AudioSource audioSourceC;
    public AudioSource audioSourceM;
    bool isOut;
    GameObject player;
    

    private void OnEnable()
    {
        player=GameObject.FindGameObjectWithTag("MainCamera");
        audioSourceC.Play();
        audioSourceM.Play();
        SoundManager.Instance.VolumeSource(SoundManager.Instance.ambientlvl1, 0.4f);
        TransitionScript.Instance.RemoveScene();
        StartCoroutine(CheckIfPlaying());


    }


    IEnumerator CheckIfPlaying()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(0.5f);
            Debug.Log(!audioSourceC.isPlaying & isOut);
            CheckIfFacingForward();
            if (!audioSourceC.isPlaying & isOut)
            {
                TransitionScript.Instance.AddScene3();

                break;
            }
        }
    }

    public float angleThreshold = 20f;

    // Forward direction to compare (can be the world's forward or some custom direction)
    public Vector3 forwardReference = Vector3.forward;

    void Update()
    {

    }

    void CheckIfFacingForward()
    {
        if (player == null)
        {
            isOut = true;
        }
        else
        {
            // Calculate the angle between the player's forward direction and the reference forward
            float angle = Vector3.Angle(player.transform.forward, forwardReference);

            // Check if the angle is within the threshold (±20 degrees)
            if (angle <= angleThreshold)
            {
                isOut = true;
            }
            else
            {
                isOut = false;
            }
        }
    }
}
