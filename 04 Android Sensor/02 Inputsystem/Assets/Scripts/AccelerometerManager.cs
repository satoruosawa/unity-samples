using UnityEngine.InputSystem;
using UnityEngine;

public class AccelerometerManager : MonoBehaviour
{

  void Start()
  {
    InputSystem.EnableDevice(Accelerometer.current);
  }


  void Update()
  {
    var acceleration = Accelerometer.current.acceleration.ReadValue();
    Debug.Log("(" + acceleration.x + "," + acceleration.y + "," +
      acceleration.z + ")");
  }

  void OnApplicationPause(bool paused)
  {
    if (paused)
    {
      InputSystem.DisableDevice(Accelerometer.current);
    }
    else
    {
      InputSystem.EnableDevice(Accelerometer.current);
    }
  }

  public void CallDisableDevice()
  {
    InputSystem.DisableDevice(Accelerometer.current);
  }

  public void CallEnableDevice()
  {
    InputSystem.EnableDevice(Accelerometer.current);
  }
}
