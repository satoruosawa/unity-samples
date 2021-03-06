using System.Collections;
using UnityEngine;

public class GPSManager : MonoBehaviour
{
  public LocationInfo location;
  bool processing;

  void Start()
  {
    processing = false;
  }

  void Update()
  {
    if (!processing)
    {
      StartCoroutine(Log());
    }
  }

  IEnumerator Log()
  {
    processing = true;

    if (!Input.location.isEnabledByUser)
    {
      Debug.Log("Location service is not enabled.");
      processing = false;
      yield break;
    }

    Input.location.Start();
    int maxWait = 20;
    while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
    {
      yield return new WaitForSeconds(1);
      maxWait--;
    }

    if (maxWait < 1)
    {
      Debug.Log("Initialization timed out.");
      processing = false;
      yield break;
    }

    if (Input.location.status == LocationServiceStatus.Failed)
    {
      Debug.Log("Unable to determine device location");
      processing = false;
      yield break;
    }
    else
    {
      location = Input.location.lastData;
      Debug.Log("Location: " + Input.location.lastData.latitude +
        " " + Input.location.lastData.longitude +
        " " + Input.location.lastData.altitude +
        " " + Input.location.lastData.horizontalAccuracy +
        " " + Input.location.lastData.timestamp);
    }

    Input.location.Stop();
  }
}