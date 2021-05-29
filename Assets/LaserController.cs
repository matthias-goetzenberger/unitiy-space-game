using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "meteor")
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 10, 0) * Time.deltaTime;

        if (transform.position.y > 6)
        {
            Destroy(this.gameObject);
        }
    }
}