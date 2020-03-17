using UnityEngine;

public class SymplexGrid : MonoBehaviour
{
    const float MIN_SQUARE_SIZE = 0.05f;
    public float _squareSize = 1.0f;
    public float SquareSize
    {
        get
        {
            if (_squareSize <= MIN_SQUARE_SIZE)
                return MIN_SQUARE_SIZE;
            return _squareSize;
        }
    }

    public bool debugDrawSymplexGrid = false;
    public bool debugDrawSquareGrid = false;
    public Vector2 debugDrawStart = Vector2.zero;
    public Vector2 debugDrawEnd = new Vector2(10, 10);

    // Start is called before the first frame update
    void Start()
    {
        skewMatrix = new float[2][];
        //skewMatrix[0] = new float[] { 1.0f, 3.0f };
        skewMatrix[0] = new float[] { 1.0f, 0.0f };
        skewMatrix[1] = new float[] { 1.0f / Mathf.Tan(Mathf.PI / 3.0f), 1.0f / Mathf.Sin(Mathf.PI / 3.0f) };
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
        if (debugDrawSymplexGrid)
            debugDrawSymplex();

        if (debugDrawSquareGrid)
            debugDrawSquare();
    }

    void debugDrawSymplex()
    {
        for (float x = debugDrawStart.x; x < debugDrawEnd.y + SquareSize; x += SquareSize)
        {
            Debug.DrawRay(skew(new Vector3(x, 0.0f, 0.0f)), skew(new Vector3(0.0f, 0.0f, debugDrawEnd.x + SquareSize - debugDrawStart.x)), Color.black);
        }

        for (float y = debugDrawStart.y; y < debugDrawEnd.x + SquareSize; y += SquareSize)
        {

            Debug.DrawRay(skew(new Vector3(0.0f, 0.0f, y)), skew(new Vector3(debugDrawEnd.y + SquareSize - debugDrawStart.y, 0.0f, 0.0f)), Color.red);
        }
    }

    void debugDrawSquare()
    {
        for (float x = debugDrawStart.x; x < debugDrawEnd.y + SquareSize; x += SquareSize)
        {
            Debug.DrawRay(new Vector3(x, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, debugDrawEnd.x + SquareSize - debugDrawStart.x), Color.black);
        }

        for (float y = debugDrawStart.y; y < debugDrawEnd.x + SquareSize; y += SquareSize)
        {

            Debug.DrawRay(new Vector3(0.0f, 0.0f, y), new Vector3(debugDrawEnd.y + SquareSize - debugDrawStart.y, 0.0f, 0.0f), Color.red);
        }
    }
}