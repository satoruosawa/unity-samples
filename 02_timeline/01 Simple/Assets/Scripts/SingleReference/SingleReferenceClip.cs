using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class SingleReferenceClip : PlayableAsset {
	public override Playable CreatePlayable (PlayableGraph graph, GameObject go) {
		return ScriptPlayable<SingleReferenceBehaviour>.Create (graph, new SingleReferenceBehaviour ());;
	}
}