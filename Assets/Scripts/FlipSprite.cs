using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;

    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(mySpriteRenderer != null)
            {
                if (mySpriteRenderer.flipX == true)
                    mySpriteRenderer.flipX = false;
                    
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (mySpriteRenderer.flipX == false)
                mySpriteRenderer.flipX = true;
        }
    }
}
