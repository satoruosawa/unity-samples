using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class System1Clip : PlayableAsset
{
  [SerializeField] float clipValue = 0.1f;
  [SerializeField] public ExposedReference<GameObject> controllerObject;

  public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
  {
    var behaviour = new System1Behaviour();
    behaviour.animator = controllerObject.Resolve(
        graph.GetResolver()).GetComponent<System1Animator>();
    behaviour.behaviourValue = clipValue;
    return ScriptPlayable<System1Behaviour>.Create(graph, behaviour);
  }
}