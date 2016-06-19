using UnityEngine;
using System.Collections;

public class LegoProperty : MonoBehaviour {

    public enum LegoNameType
    {
        Cube, Triangle, Sphere, Rectangle, ShortRectangle, Cylinder
    }

    public LegoNameType legoName;

    private bool isSet = false;
    private bool finishLerp = false;
    private Transform startPosition;
    private Transform endPosition;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;

    public void startLerp(Transform start, Transform end)
    {
        isSet = true;
        startPosition = start;
        endPosition = end;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPosition.position, endPosition.position);
    }

    void Update()
    {
        if (isSet && !finishLerp)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startPosition.position, endPosition.position, fracJourney);
            transform.rotation = Quaternion.Lerp(startPosition.rotation, endPosition.rotation, fracJourney);
            if (fracJourney >= 1) finishLerp = true;
        }
    }

    public bool getFinidhLerp() { return finishLerp; }
}
