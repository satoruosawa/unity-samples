using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class CustomClip : PlayableAsset, ITimelineClipAsset {
	public ClipCaps clipCaps {
		get { return ClipCaps.Extrapolation; }
	}

	public override Playable CreatePlayable (PlayableGraph graph, GameObject go) {
		return ScriptPlayable<CustomBehaviour>.Create (graph, new CustomBehaviour ());;
	}
}