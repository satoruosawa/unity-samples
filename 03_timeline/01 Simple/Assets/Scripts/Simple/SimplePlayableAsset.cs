using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class SimplePlayableAsset : PlayableAsset {
	public ClipCaps clipCaps {
		get { return ClipCaps.Extrapolation; }
	}

	public override Playable CreatePlayable (PlayableGraph graph, GameObject go) {
		SimplePlayableBehaviour behaviour = new SimplePlayableBehaviour ();
		behaviour.cubeObject = go;
		return ScriptPlayable<SimplePlayableBehaviour>.Create (graph, behaviour);
	}
}