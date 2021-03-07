using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogError("bitch");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogText.text = dialog;
                dialogBox.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.LogError("kms");
        if (other.CompareTag("Player"))
        {
            Debug.LogError("in range");
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            Debug.LogError("yeet");
        }
    }
}
