using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleHealthWasm.Services {
	public interface ISpreadsheetService {
		Task<IEnumerable<HeartPressureReading>> GetReadings();
	}
}