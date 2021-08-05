using UnityEngine.Playables;
using UnityEngine;

public class System1Behaviour : PlayableBehaviour
{
  public System1Animator animator;
  public float behaviourValue;

  // public override void OnBehaviourPause(Playable playable, FrameData info)
  // {
  //   Debug.Log("OnBehaviourPause");
  // }

  public override void OnBehaviourPlay(Playable playable, FrameData info)
  {
    animator.Call(behaviourValue);
    Debug.Log("OnBehaviourPlay");
  }

  // public override void OnGraphStart(Playable playable)
  // {
  //   Debug.Log("OnGraphStart");
  // }

  // public override void OnGraphStop(Playable playable)
  // {
  //   Debug.Log("OnGraphStop");
  // }

  // public override void OnPlayableCreate(Playable playable)
  // {
  //   Debug.Log("OnPlayableCreate");
  // }

  // public override void OnPlayableDestroy(Playable playable)
  // {
  //   Debug.Log("OnPlayableDestroy");
  // }

  // public override void PrepareData(Playable playable, FrameData info)
  // {
  //   Debug.Log("PrepareData");
  // }

  // public override void PrepareFrame(Playable playable, FrameData info)
  // {
  //   Debug.Log("PrepareFrame");
  // }

  // public override void ProcessFrame(Playable playable, FrameData info, object playerData)
  // {
  //   Debug.Log("ProcessFrame");
  // }
}