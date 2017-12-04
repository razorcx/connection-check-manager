using System.Collections.Generic;

namespace ConnectionCheckManager
{
	public class ConnectionCheckSummary
	{
		public string GUID { get; set; }
		public List<ConnectionCheckResult> ConnectionCheckResults { get; set; }
	}
}