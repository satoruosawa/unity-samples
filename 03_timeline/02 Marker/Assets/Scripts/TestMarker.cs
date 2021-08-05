using UnityTestClass;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[System.Serializable]
public class TestMarker : Marker, INotification
{
  [SerializeField] public Values values;

  public PropertyName id
  {
    get
    {
      return new PropertyName("method");
    }
  }
}