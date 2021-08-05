using UnityEngine;
using UnityEngine.Playables;

namespace UnityTestClass
{
  public class TestMarkerReceiver : MonoBehaviour, INotificationReceiver
  {

    void Start()
    {
    }

    public void OnNotify(Playable origin, INotification notification,
      object context)
    {
      var element = notification as TestMarker;
      if (element == null) return;
      Debug.Log("Value1 " + element.values.value1);
      Debug.Log("Value2 " + element.values.value2);
      Debug.Log("Value3 " + element.values.value3);
    }
  }

  [System.Serializable]
  public class Values
  {
    public string value1;
    public string value2;
    [HideInInspector] public string value3 = "3";
  }
}