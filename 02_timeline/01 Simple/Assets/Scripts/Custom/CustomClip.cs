using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class CustomClip : PlayableAsset, ITimelineClipAsset {
	public CustomMixerBehaviour template = new CustomMixerBehaviour ();

	public ClipCaps clipCaps {
		get { return ClipCaps.Extrapolation; }
	}

	public override Playable CreatePlayable (PlayableGraph graph, GameObject go) {
		return ScriptPlayable<CustomMixerBehaviour>.Create (graph, template);;
	}
}