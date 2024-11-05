using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 1f;
    float speed2 = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Wanneer drukt iemand op WASD of pijltjes drukken?
        // TODO: Player moet vooruit bij W of pijl omhoog.
        // Achteruit bij S of pijl naar beneden.
        // TODO: Draai naar links bij A of pijl links.
        // Draai naar recht bij D of pijl naar recht.

        float inputVer = Input.GetAxis("Vertical");
        float inputHor = Input.GetAxis("Horizontal");
        float inputBackwards = Input.GetAxis("Backwards");
        if (inputHor != 0)
        {
            //wel input
            gameObject.transform.Rotate(0, inputHor * speed2 * Time.deltaTime, 0);
        }
        if (inputVer != 0)
        {
            // transform.forward
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
