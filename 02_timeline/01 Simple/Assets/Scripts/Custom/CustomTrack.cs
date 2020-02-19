using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

[TrackColor (0.875f, 0.5944853f, 0.1737132f)]
[TrackClipType (typeof (CustomClip))]
[TrackBindingType (typeof (GameObject))]
public class CustomTrack : TrackAsset {
	public override Playable CreateTrackMixer (
		PlayableGraph graph, GameObject go, int inputCount) {
		return ScriptPlayable<CustomMixerBehaviour>.Create (graph, inputCount);
	}
}