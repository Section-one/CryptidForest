using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymplexGrid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        skewMatrix = new float[2][];
        //skewMatrix[0] = new float[] { 1.0f, 3.0f };
        skewMatrix[0] = new float[] { 1.0f, 0.0f };
        skewMatrix[1] = new float[] { 1.0f / Mathf.Tan(Mathf.PI /3.0f),  1.0f / Mathf.Sin(Mathf.PI /3.0f)};
        //skewMatrix[1] = new float[] { 0.0f, 1.0f };
    }

    float[][] skewMatrix;
    Vector2 skew(Vector2 point)
    {
        Vector2 output = Vector2.zero;
        output.x = (skewMatrix[0][0] * point.x) + (skewMatrix[0][1] * point.y);
        output.y = (skewMatrix[1][0] * point.x) + (skewMatrix[1][1] * point.y);
        return output;
    }

    Vector3 skew(Vector3 point)
    {
        Vector2 skewed = skew(new Vector2(point.x, point.z));
        return new Vector3(skewed.x, 0.0f, skewed.y);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(1.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(2.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(3.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(4.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(5.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(6.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(7.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(8.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
        Debug.DrawRay(skew(new Vector3(9.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 10.0f)), Color.black);
                                                                                                                                                                                    
                                                                                              
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 0.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 1.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 2.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 3.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 4.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 5.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 6.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 7.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 8.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 9.0f)), skew(new Vector3(10.0f, 0.0f, 0.0f)), Color.red);

        /*
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 0.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 1.0f)), skew(new Vector3(1.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 1.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 2.0f)), skew(new Vector3(2.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 2.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 3.0f)), skew(new Vector3(3.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 3.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 4.0f)), skew(new Vector3(4.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 4.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 5.0f)), skew(new Vector3(5.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 5.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 6.0f)), skew(new Vector3(6.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 6.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 7.0f)), skew(new Vector3(7.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 7.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 8.0f)), skew(new Vector3(8.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 8.0f)), Color.blue);
        Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, 9.0f)), skew(new Vector3(9.0f, 0.0f, 0.0f) - new Vector3(0.0f, 0.0f, 9.0f)), Color.blue);*/
    }
}