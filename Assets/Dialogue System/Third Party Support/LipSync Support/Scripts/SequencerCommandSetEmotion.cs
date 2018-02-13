using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using RogoDigital.Lipsync;

namespace PixelCrushers.DialogueSystem.SequencerCommands {

	/// <summary>
	/// SetEmotion() sequencer command for Rogo Digital's LipSync. Syntax:
	/// 
	/// SetEmotion(emotionName, [blendTime], [subject])
	/// 
	/// - emotion: The name of an emotion defined on the LipSync component.
    /// - blendTime: (Optional) Duration to blend into the emotion. Default: 0.3s.
	/// - subject: (Optional) The GameObject on which to set the emotion. Default: speaker.
    /// </summary>
	public class SequencerCommandSetEmotion : SequencerCommand {

		public void Start() {
            var emotion = GetParameter(0);
            var blendTime = GetParameterAsFloat(1, 0.3f);
			var subject = GetSubject(2, Sequencer.Speaker);
			var lipSync = (subject == null) ? null : subject.GetComponentInChildren<LipSync>();
			if (lipSync == null) {
				if (DialogueDebug.LogWarnings) Debug.LogWarning("Dialogue System: Sequencer: SetEmotion(" + GetParameters() + "): LipSync subject not found");
			} else {
                if (DialogueDebug.LogInfo) Debug.Log("Dialogue System: Sequencer: SetEmotion(" + emotion + ", blendTime=" + blendTime + ", " + subject);
                lipSync.SetEmotion(emotion, blendTime);
			}
			Stop();
		}
		
	}

}
