using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject dialogBox1;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                dialogBox1.SetActive(false);
            }
            else
            {
                dialogText.text = dialog;
                dialogBox.SetActive(true);
                dialogBox1.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            dialogBox1.SetActive(false);
        }
    }
}
