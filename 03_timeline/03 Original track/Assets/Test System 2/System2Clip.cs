using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class System2Clip : AClip
{
  [SerializeField] float clipValue = 0.1f;

  public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
  {
    var behaviour = new System2Behaviour();
    behaviour.behaviourValue = clipValue;
    return ScriptPlayable<System2Behaviour>.Create(graph, behaviour);
  }
}