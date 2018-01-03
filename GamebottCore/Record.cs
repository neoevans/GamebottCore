using System;

namespace GamebottCore
{
	public class Record
	{
		public void getActions()
		{
			/* Capture the output log from Unity and parse for unique actions
			 * i.e. Keyboard inputs
			 * i.e. Mouse actions
			 * i.e. Gamepad actions
			 */
			return;
		}

		public void getDelayTime()
		{
			// capture delay time between user actions
			return;
		}

		public void getEvents()
		{
			// i.e. game/level start/stop, nextlevel, win/lose
			return;
		}
	}

	public class Parse
	{
		public void Parser(Record a)
		{
			// iterate over the Record object and output to a human-readable log file
			System.IO.StreamWriter recording = new System.IO.StreamWriter ("./recording.txt", true);
			recording.WriteLine(
				a.getActions (), "/n",
				a.getDelayTime (), "/n",
				a.getEvents (), "/n",
			);
			recording.Close();
		}
	}

	public class Replay
	{
		// Find a way to feed parsed and sorted actions back into game during replay
	}

}

