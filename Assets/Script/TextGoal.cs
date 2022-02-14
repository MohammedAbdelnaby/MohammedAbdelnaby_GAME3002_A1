using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextGoal : MonoBehaviour
{
    public Text txt;

    [SerializeField]
    private GameObject Score;

    [SerializeField]
    private GameObject Score2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + (Score.GetComponent<Goal>().score - Score2.GetComponent<Goal>().score);
    }
}
