using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMoverDisabler : MonoBehaviour
{
    private SpriteMover spriteMover;
    private bool Disabled;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        spriteMover = GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    void Update()
    {
        //toggles movement on and off
        if (Input.GetKeyDown(KeyCode.P))
            if (Disabled == false)
            {
                spriteMover.enabled = false;
                Disabled = true;
            }
            else if (Disabled == true)
        {
            spriteMover.enabled = true;
        }
    }
}
