using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetObjScript : MonoBehaviour
{
    public GameObject target;
    public AudioClip soundEffect;
    public Image winImage;
    public Text winText;
    public static float spawnTimer = 2f;
    public static int score = 0;
    public static int maxScore = 14; // Added the missing variable name
    public static bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("repeating", 0.0f, spawnTimer); // Corrected the spelling of "repeating"
    }

    // Update is called once per frame
void Update()
{
    // Update the score text
    winText.text = "Score: " + score;

    // Check if the left mouse button is pressed
    if (Input.GetMouseButton(0))
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
    }
        if (win == false)
        {
            Debug.Log("You Win!");
            winImage.enabled = true;
            CancelInvoke("repeating");
        }
}

    void repeating()
    {
        Vector3 pos = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-4f, 5f), 0);
        Instantiate(target, pos, Quaternion.identity);
    }

}

