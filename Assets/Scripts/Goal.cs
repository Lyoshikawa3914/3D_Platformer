using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject popupPanel;
    // Start is called before the first frame update
    void Start()
    {
        HidePopup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void onTriggerEvent(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShowPanel();
        }
    }

    void HidePopup()
    {
        popupPanel.SetActive(false);
    }

    void ShowPanel()
    {
        popupPanel.SetActive(true);
    }
}
