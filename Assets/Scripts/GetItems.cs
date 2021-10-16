using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    public JumpingCharacter charac;
    // Start is called before the first frame update
    void Start()
    {
        charac = gameObject.GetComponentInParent<JumpingCharacter>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("item"))
        {
            SoundEffect.PlaySound("getItem");
            Destroy(collision.gameObject);
            Score.scoreValue++;
        }
    }
}
