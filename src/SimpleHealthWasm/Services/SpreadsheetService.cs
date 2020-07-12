using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleHealthWasm.Services {
	public class SpreadsheetService : ISpreadsheetService {
		public async Task<IEnumerable<HeartPressureReading>> GetReadings() {
			var results = new List<HeartPressureReading> {
				new HeartPressureReading { TakenOn = DateTime.Now.AddDays(-2), Sys = 144, Dia = 71 },
				new HeartPressureReading { TakenOn = DateTime.Now.AddDays(-1), Sys = 132, Dia = 78 }
			};

			var fileUri = @"https://1drv.ms/x/s!AoIilwXIs8iCsrlMAKumUWgrZKmChQ?e=caJCUG";


			//GraphServiceClient graphClient = new GraphServiceClient(authProvider);

			//var driveItem = await graphClient.Shares[fileUri].DriveItem
			//	.Request()
			//	.GetAsync();

			await Task.Delay(100);
			return results;
		}
	}
}
