using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTower : MonoBehaviour
{
    public GameObject chaseTower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChaseTowerToggle()
    {
        if (chaseTower.activeSelf)
        {
            chaseTower.SetActive(false);
        }
        else
        {
            chaseTower.SetActive(true);
        }
    }
}
