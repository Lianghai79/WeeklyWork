using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerButtons : MonoBehaviour
{
    public GameObject player;
    PlayerManager playerManagerScript;
    // Start is called before the first frame update

    private void Awake()
    {
        player = GameObject.Find("Player");
        playerManagerScript = player.GetComponent<PlayerManager>();
    }
    void Start()
    {
       
    }

    public void AddHealth() {
        playerManagerScript.IncreaseHealth(1.0f);
    }
    public void ReduceHealth()
    {
        playerManagerScript.ReduceHealth(1.0f);
    }
    public void AddStrength()
    {
        playerManagerScript.IncreaseStrength(1);
    }
    public void ReduceStrength()
    {
        playerManagerScript.ReduceStrength(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
