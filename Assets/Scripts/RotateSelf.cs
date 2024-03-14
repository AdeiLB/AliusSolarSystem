using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    private float y;
    public float velRot = 1;
    public bool rotate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkRotation();
    }

    private void checkRotation()
    {
        if (rotate)
        {
            y += Time.deltaTime *100* velRot;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
        
    }
}
