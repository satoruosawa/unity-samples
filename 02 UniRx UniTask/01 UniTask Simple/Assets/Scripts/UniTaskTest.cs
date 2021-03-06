using Cysharp.Threading.Tasks;
using System.Collections;
using System.Threading;
using UnityEngine;

public class UniTaskTest : MonoBehaviour
{
  void Start()
  {
    // AsyncTest1();
    // AsyncTest2();
    // AsyncTest3();
    AsyncTest4();
  }

  async void AsyncTest1()
  {
    await AsyncTest1_1("Test1 1", 1.0f);
    await AsyncTest1_1("Test1 2", 1.0f);
    await AsyncTest1_1("Test1 3", 1.0f);
  }

  IEnumerator AsyncTest1_1(string str, float seconds)
  {
    var start = Time.time;
    while (Time.time - start <= seconds)
    {
      yield return null;
    }
    Debug.Log(str);
  }

  async void AsyncTest2()
  {
    await AsyncTest2_1("Test2 1", 1.0f);
    await AsyncTest2_1("Test2 2", 1.0f);
    await AsyncTest2_1("Test2 3", 1.0f);
  }

  async UniTask AsyncTest2_1(string str, float seconds)
  {
    await UniTask.Delay((int)(seconds * 1000));
    Debug.Log(str);
  }

  async void AsyncTest3()
  {
    await AsyncTest3_1("Test3 1", 1.0f);
    await AsyncTest3_1("Test3 2", 1.0f);
    await AsyncTest3_1("Test3 3", 1.0f);
  }

  async UniTask AsyncTest3_1(string str, float seconds)
  {
    await AsyncTest3_2("Test3_1 1", 1.0f);
    await AsyncTest3_2("Test3_1 2", 1.0f);
    await AsyncTest3_2("Test3_1 2", 1.0f);
    Debug.Log(str);
  }

  async UniTask AsyncTest3_2(string str, float seconds)
  {
    await UniTask.Delay((int)(seconds * 1000));
    Debug.Log(str);
  }

  async void AsyncTest4()
  {
    await AsyncTest4_1("Test4 1", 1.0f, this.GetCancellationTokenOnDestroy());
    await AsyncTest4_1("Test4 2", 1.0f, this.GetCancellationTokenOnDestroy());
    await AsyncTest4_1("Test4 3", 1.0f, this.GetCancellationTokenOnDestroy());
  }

  async UniTask AsyncTest4_1(string str, float seconds, CancellationToken cancellationToken)
  {
    var start = Time.time;
    while (Time.time - start <= seconds)
    {
      await UniTask.Yield(PlayerLoopTiming.Update, cancellationToken);
    }
    Debug.Log(str);
  }
}
