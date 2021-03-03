using Cysharp.Threading.Tasks;
using UnityEngine;
using System.Collections;

public class UniTaskTest : MonoBehaviour
{
  void Start()
  {
    AsyncTest();
  }

  async void AsyncTest()
  {
    await IETest("1", 1.0f);
    await IETest("2", 1.0f);
    await IETest("3", 1.0f);
    await IETest("4", 1.0f);
  }

  IEnumerator IETest(string str, float seconds)
  {
    var start = Time.time;
    while (Time.time - start <= seconds)
    {
      yield return null;
    }
    Debug.Log(str);
  }
}
