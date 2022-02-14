using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerText : MonoBehaviour
{
    public Text txt;

    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Power: " + (int)(player.GetComponent<PlayerController>().getPowerForward() + player.GetComponent<PlayerController>().getPowerUp());
    }
}
