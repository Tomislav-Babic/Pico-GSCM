using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerProjection : MonoBehaviour
{
    public GameObject projection;
    
    public void ProjectTrigger()
    {
        projection.SetActive(true);
    }
}
