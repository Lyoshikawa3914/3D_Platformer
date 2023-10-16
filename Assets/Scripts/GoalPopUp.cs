using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPopUp : MonoBehaviour
{
    public GameObject popupPanel;
    private bool hasLanded = false;
    // Start is called before the first frame update
    void Start()
    {
        popupPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasLanded = true;
            popupPanel.SetActive(true);
        }
    }


}
