using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkInterfaces.Interfaces;

namespace HomeWorkInterfaces.TV
{
    public class RemoteControl : INumberButton, IArrowClick
    {
		private static void PrintButtonPress(int buttonNumber)
		{
			Console.WriteLine($"You pressed the button {buttonNumber}");
		}
		private static void PrintArrowPress(string direction)
		{
			Console.WriteLine($"You pressed the arrow {direction}");
		}

		public void PressButton1() => PrintButtonPress(1);
		public void PressButton2() => PrintButtonPress(2);
		public void PressButton3() => PrintButtonPress(3);
		public void PressButton4() => PrintButtonPress(4);
		public void PressButton5() => PrintButtonPress(5);
		public void PressButton6() => PrintButtonPress(6);
		public void PressButton7() => PrintButtonPress(7);
		public void PressButton8() => PrintButtonPress(8);
		public void PressButton9() => PrintButtonPress(9);

		public void PressUp() => PrintArrowPress("Up");
		public void PressDown() => PrintArrowPress("Down");
		public void PressLeft() => PrintArrowPress("Left");
		public void PressRight() => PrintArrowPress("Right");
	}
}
