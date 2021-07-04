using UnityEngine;
using System.Collections;

namespace RootMotion.FinalIK {

	/// <summary>
	/// CCD (Cyclic Coordinate Descent) %IK solver component.
	/// </summary>
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK {

		// Open the User Manual URL
		[ContextMenu("User Manual")]
		protected override void OpenUserManual() {
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page5.html");
		}
		
		// Open the Script Reference URL
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference() {
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
		}
		
		// Link to the Final IK Google Group
		[ContextMenu("Support Group")]
		void SupportGroup() {
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}
		
		// Link to the Final IK Asset Store thread in the Unity Community
		[ContextMenu("Asset Store Thread")]
		void ASThread() {
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		/// <summary>
		/// The CCD %IK solver.
		/// </summary>
		public IKSolverCCD solver = new IKSolverCCD();
		
		public override IKSolver GetIKSolver() {
			return solver as IKSolver;
		}

		private void OnDrawGizmos()
		{
			int lastIndex = solver.bones.Length - 1;
			for(int i =0;i< solver.bones.Length; i++)
			{
				Gizmos.color = Color.white;
				Gizmos.DrawLine(solver.bones[i].transform.position, solver.bones[lastIndex].transform.position);
				Gizmos.color = Color.red;
				Gizmos.DrawLine(solver.bones[i].transform.position, solver.IKPosition);
			}
		}
	}
}
