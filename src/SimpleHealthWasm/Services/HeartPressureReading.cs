using System;

namespace SimpleHealthWasm.Services {
	public class HeartPressureReading {
		public DateTime TakenOn { get; set; }
		public int Sys { get; set; }
		public int Dia { get; set; }
	}
}