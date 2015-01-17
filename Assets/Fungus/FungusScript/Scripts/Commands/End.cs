using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Fungus
{
	[CommandInfo("Scripting", 
	             "End", 
	             "Marks the end of a conditional block.")]
	[AddComponentMenu("")]
	public class End : Command
	{
		public override void OnEnter()
		{
			Continue();
		}

		public override int GetPreIndent()
		{
			return -1;
		}

		public override Color GetButtonColor()
		{
			return new Color32(253, 253, 150, 255);
		}
	}

}