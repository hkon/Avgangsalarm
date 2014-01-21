using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Avgangsalarm.Core
{
	public class TrafikkDatAdapter : ITrafikkDatAdapter
	{
		#region ITrafikkDataService implementation

		private const string GetStoppUri = "http://reis.trafikanten.no/reisrest/realtime/getalldepartures/";

		public Task<IEnumerable<LineDeparture>> GetLineDeparturesForStopId (int stopId)
		{
			var client = CreateClient(GetStoppUri);
			var content = client.GetStringAsync(stopId.ToString()).Result;
			//var result = SimpleJson.DeserializeObject<IEnumerable<LineDeparture>>(content);		

			//return Task.FromResult(result);
			throw new NotImplementedException ();
		}

		private static HttpClient CreateClient(string uri)
		{
			var client = new HttpClient
			{
				BaseAddress = new Uri(uri)
			};
			return client;
		}

		#endregion
	}
}

