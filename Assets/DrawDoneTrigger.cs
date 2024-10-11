using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DrawDoneTrigger : MonoBehaviour
{
    public Animator animator;
    //GameObject[] 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoneCheck());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DoneCheck()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1);

            // Set flag to true initially
            bool allTriggered = true;

            // Loop through all child objects
            foreach (Transform t in transform)
            {
                // Get the DrawTriggerDetection component from the child
                DrawTriggerDetection detection = t.GetComponent<DrawTriggerDetection>();

                // If a child is not triggered, set flag to false
                if (!detection.istriggered)
                {
                    allTriggered = false;
                    break; // Exit early since we found one untriggered child
                }
            }

            // If all children are triggered, perform your action
            if (allTriggered)
            {
                animator.SetTrigger("PlaySlurp");
                Debug.Log("All children triggered!");
                // Perform whatever action you want to take when all children are triggered
            }
        }
    }

}
