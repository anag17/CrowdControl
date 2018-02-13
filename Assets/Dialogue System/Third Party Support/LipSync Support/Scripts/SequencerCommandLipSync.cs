using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using RogoDigital.Lipsync;

namespace PixelCrushers.DialogueSystem.SequencerCommands {

	/// <summary>
	/// LipSync() sequencer command for Rogo Digital's LipSync. Syntax:
	/// 
	/// LipSync(lipSyncData, [subject], [nowait])
	/// 
	/// - lipSyncData: Name of a LipSync Data asset in a Resources folder.
	/// - subject: (Optional) The GameObject through which to play the 
	///   LipSync Data. Must have a LipSync component.
	/// - nowait: (Optional) If the third argument is 'nowait', the sequencer
	///   command kicks off the playback and immediately exits. Otherwise it
	///   waits until the playback is done.
	/// </summary>
	public class SequencerCommandLipSync : SequencerCommand {

		private LipSync lipSync;
		private bool nowait;

		public void Start() {
			var lipSyncAssetName = GetParameter(0);
			var lipSyncData = DialogueManager.LoadAsset(lipSyncAssetName, typeof(LipSyncData)) as LipSyncData;
			var subject = GetSubject(1, Sequencer.Speaker);
			lipSync = (subject == null) ? null : subject.GetComponentInChildren<LipSync>();
			nowait = string.Equals(GetParameter(2), "nowait", System.StringComparison.OrdinalIgnoreCase);
			if (lipSync == null) {
				if (DialogueDebug.LogWarnings) Debug.LogWarning("Dialogue System: Sequencer: LipSync(" + GetParameters() + "): LipSync subject not found");
			} else if (lipSyncData == null) {
				if (DialogueDebug.LogWarnings) Debug.LogWarning("Dialogue System: Sequencer: LipSync(" + GetParameters() + "): LipSync Data not found");
			} else {
				if (DialogueDebug.LogInfo) Debug.Log("Dialogue System: Sequencer: LipSync(" + lipSyncData + ", " + lipSync + (nowait ? ", nowait" : string.Empty) + ")");
				lipSync.Play(lipSyncData);
			}
			if (nowait) Stop();
		}
		
		public void Update() {
			if (DialogueTime.IsPaused) {
				if (!lipSync.IsPaused) lipSync.Pause();
			} else {
				if (lipSync.IsPaused) lipSync.Resume();
				if (!lipSync.IsPlaying) Stop();
			}
		}
		
		public void OnDestroy() {
			if (!nowait) lipSync.Stop(true);
		}
		
	}

}
