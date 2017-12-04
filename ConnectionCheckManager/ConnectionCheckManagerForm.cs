using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using StackExchange.Redis;
using Tekla.Structures.Model;

namespace ConnectionCheckManager
{
	public partial class ConnectionCheckManagerForm : Form
	{
		private readonly Model _model;
		private readonly ConnectionMultiplexer _redis;

		public ConnectionCheckManagerForm()
		{
			try
			{
				_redis = ConnectionMultiplexer.Connect("localhost");

				InitializeComponent();

				_model = new Model();
				if (!_model.GetConnectionStatus()) return;

				RefreshUi();

				RefreshDatabase();
			}
			catch(Exception ex)
			{
				Trace.WriteLine(ex.Message + ex.InnerException + ex.StackTrace);
			}
		}

		private void RefreshDatabase()
		{
			var db = _redis.GetDatabase();

			var connectionCheckViews = GetConnectionCheckViews();

			connectionCheckViews.ForEach(c =>
			{
				db.StringSetAsync(c.GUID, JsonConvert.SerializeObject(c, Formatting.Indented));
			});
		}

		private void RefreshUi()
		{
			ModelObjectEnumerator.AutoFetch = true;
			var connections = _model.GetModelObjectSelector()
				.GetAllObjectsWithType(ModelObject.ModelObjectEnum.CONNECTION)
				.ToList();

			var connectionCheckResults = ConnectionCheckResults();

			var summary = connections.Select(c => new
				{
					Connection = c,
					ConnectionCheckPlugin =
						connectionCheckResults.FirstOrDefault(cc => cc?.Connection?.Identifier?.GUID == c?.Identifier?.GUID)
				})
				.ToList();

			textBoxWithPluginCount.Text = summary.Count(c => c.ConnectionCheckPlugin != null).ToString();
			textBoxWithoutPluginCount.Text = summary.Count(c => c.ConnectionCheckPlugin == null).ToString();

			var results = summary
				.Where(c => c.ConnectionCheckPlugin != null)
				.Select(c => c.ConnectionCheckPlugin)
				.OrderByDescending(c => c.Date)
				.ToList();

			this.dataGridViewConnectionCheckingSummary.DataSource 
				= GetConnectionCheckView(results);
		}

		private List<ConnectionCheckResult> ConnectionCheckResults()
		{
			var connectionViews = GetConnectionCheckViews();

			return connectionViews.Select(c =>
				{
					var result = c.ConnectionCheckResults.LastOrDefault();
					return result ?? new ConnectionCheckResult();
				})
				.OrderByDescending(c => c.Date)
				.ToList();
		}

		private List<ConnectionCheckSummary> GetConnectionCheckViews()
		{
			var fileNames = GetFilenames();

			return fileNames.AsParallel().Select(f =>
				{
					var guid = f.Split('\\').LastOrDefault()?.Split('.').FirstOrDefault();
					var connectionCheckResults = ReadConnectionCheckHistory(f);

					return new ConnectionCheckSummary
					{
						GUID = guid,
						ConnectionCheckResults = connectionCheckResults
					};
				})
			.ToList();
		}

		private List<string> GetFilenames()
		{
			var folder = FolderPath();
			return Directory.EnumerateFiles(FolderPath()).ToList();
		}

		private string FolderPath()
		{
			string modelpath = _model.GetInfo().ModelPath;
			var connectionCheckFolder = @"RazorCX\ConnectionChecker";
			return modelpath + @"\" + connectionCheckFolder;
		}

		private List<ConnectionCheckResult> ReadConnectionCheckHistory(string filepath)
		{
			var checkConnections = new List<ConnectionCheckResult>();

			try
			{
				var file = string.Empty;

				using (var reader = new StreamReader(filepath))
					file = reader.ReadToEnd();

				if (!string.IsNullOrEmpty(file))
					checkConnections =
						JsonConvert.DeserializeObject<List<ConnectionCheckResult>>(file);

				return checkConnections;
			}
			catch (Exception ex)
			{
				return checkConnections;
			}
		}

		private List<ConnectionCheckView> GetConnectionCheckView(List<ConnectionCheckResult> result)
		{
			return
				result
					.Select(c => new ConnectionCheckView
					{
						Id = c?.Id,
						Phase = c?.Phase,
						Name = c?.Name,
						Number = c?.Number,
						DetailedBy = c?.DetailedBy,
						DetailedDate = c?.DetailedDate,
						DetailedComments = c?.DetailedComments,
						DesignedBy = c?.DesignedBy,
						DesignedDate = c?.DesignedDate,
						DesignedComments = c?.DesignedComments,
						CheckedBy = c?.CheckedBy,
						CheckedDate = c?.CheckedDate,
						CheckedComments = c?.CheckedComments,
						ApprovedBy = c?.ApprovedBy,
						ApprovedDate = c?.ApprovedDate,
						ApprovedComments = c?.ApprovedComments,
						Date = c?.Date
					}).ToList();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefreshUi();
		}
	}
}
