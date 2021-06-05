using Binance.Net;
using Binance.Net.Enums;
using Binance.Net.Objects.Spot;
using Binance.Net.Objects.Spot.SpotData;
using ClosedXML.Excel;
using CryptoExchange.Net.Authentication;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BinanceOrderList
{
	public partial class DataForm : Form
	{
		private List<Order> orderList = new List<Order>();
		private List<string> pairSymbolsList = new List<string>();

		private OrderStatus orderStatus;
		private OrderSide orderSide;

		public DataForm()
		{
			InitializeComponent();
		}

		public void GetData(string apiPublicKey, string apiSecretKey, string pairSymbols, DateTime fromDate, DateTime toDate, string status, string side, Point formLocation)
		{
			string mainError = string.Empty;
			string noDataError = string.Empty;

			string[] symbols = pairSymbols.Split(',');

			ClearData();

			foreach (string symbol in symbols)
				if (!string.IsNullOrWhiteSpace(symbol))
					pairSymbolsList.Add(symbol.Replace(" ", "").Trim());

			if (status != "All")
				Enum.TryParse(status, out orderStatus);

			if (side != "All")
				Enum.TryParse(status, out orderSide);

			BinanceClient client = new BinanceClient(new BinanceClientOptions
			{
				ApiCredentials = new ApiCredentials(apiPublicKey, apiSecretKey),
			});

			foreach (string pair in pairSymbolsList)
			{
				var result = client.Spot.Order.GetAllOrders(pair, null, fromDate);

				if (result.Success)
				{
					List<BinanceOrder> resultDataList = result.Data.ToList();

					if (resultDataList.Count > 0)
					{
						int rowId = int.MinValue;
						binanceDataDataGridView.Columns["DateColumn"].DefaultCellStyle.Format = "dd/MM/yyyy";
						binanceDataDataGridView.Columns["UpdateTimeColumn"].DefaultCellStyle.Format = "dd/MM/yyyy";

						foreach (BinanceOrder data in resultDataList)
						{
							if (status != "All" && data.Status != orderStatus) continue;
							if (side != "All" && data.Side != orderSide) continue;
							if (data.CreateTime > toDate) continue;

							Order order = new Order();

							rowId = binanceDataDataGridView.Rows.Add();
							DataGridViewRow row = binanceDataDataGridView.Rows[rowId];

							row.Cells["DateColumn"].Value = data.CreateTime;
							row.Cells["DateColumn"].ToolTipText = data.CreateTime.ToString();
							order.Date = data.CreateTime;

							row.Cells["UpdateTimeColumn"].Value = data.UpdateTime;
							row.Cells["UpdateTimeColumn"].ToolTipText = data.UpdateTime.ToString();
							order.UpdateTime = (DateTime) data.UpdateTime;

							row.Cells["PairColumn"].Value = data.Symbol;
							order.Pair = data.Symbol;

							if (data.Quantity > 1)
								row.Cells["QuanityColumn"].Value = data.Quantity.ToString("0.#############################");
							else
								row.Cells["QuanityColumn"].Value = data.Quantity;
							order.Quanity = data.Quantity;

							bool limitTwoDecimals = false;
							foreach (string currency in Constants.LimitTwoDecimalsCurrencies)
								if (data.Symbol.EndsWith(currency))
								{
									limitTwoDecimals = true;
									break;
								}

							if (limitTwoDecimals)
								row.Cells["PriceColumn"].Value = Math.Round(data.Price, 2);
							else
								row.Cells["PriceColumn"].Value = data.Price;
							order.Price = data.Price;

							if (data.Status == OrderStatus.PartiallyFilled)
							{
								decimal filledPercent = Math.Round((data.QuantityFilled / data.Quantity) * 100, 0);
								row.Cells["StatusColumn"].Value = data.Status + " (" + filledPercent + "%)";
								row.Cells["StatusColumn"].ToolTipText = "Filled: " + data.QuantityFilled.ToString();
								order.Status = data.Status + " (" + filledPercent + "% - " + data.QuantityFilled + ")"; 
							}
							else
							{
								row.Cells["StatusColumn"].Value = data.Status;
								order.Status = data.Status.ToString();
							}

							row.Cells["TypeColumn"].Value = data.Type;
							order.Type = data.Type;

							row.Cells["SideColumn"].Value = data.Side;
							order.Side = data.Side;

							orderList.Add(order);
						}

						if (rowId < 0)
							noDataError += "- " + pair + ": No data found!\n";
						else
						{
							Show();
							Location = formLocation;
						}
					}
					else
						noDataError += "- " + pair + ": No data found!\n";
				}
				else
					mainError += "- " + pair + ": " + result.Error + "\n";
			}

			if (!string.IsNullOrEmpty(mainError))
				MessageBox.Show(mainError, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

			if (!string.IsNullOrEmpty(noDataError))
				MessageBox.Show(noDataError, "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ClearData()
		{
			pairSymbolsList.Clear();
			binanceDataDataGridView.Rows.Clear();
			binanceDataDataGridView.Refresh();
			orderList.Clear();
		}

		#region UI Events
		#region Buttons
		private void ClearDataButton_Click(object sender, EventArgs e)
		{
			ClearData();
		}

		private void ExportToExcelButton_Click(object sender, EventArgs e)
		{
			if (orderList.Count <= 0)
			{
				MessageBox.Show("No data to export.", "No Data!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog() {
				Filter = "Excel Workbook|*.xlsx",
				FileName = "Data Export " + DateTime.Today.ToString("MM-dd-yyyy"),
				RestoreDirectory = true
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					XLWorkbook workbook = new XLWorkbook();
					IXLWorksheet worksheet = workbook.Worksheets.Add("Exported Data");

					for (int i = 0; i < binanceDataDataGridView.ColumnCount; i++)
						worksheet.Cell(1, i + 1).Value = binanceDataDataGridView.Columns[i].HeaderText;

					worksheet.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

					//Row Styles
					worksheet.Row(1).Style.Font.FontSize = 12;
					worksheet.Row(1).Style.Font.Bold = true;
					worksheet.Row(1).Style.Fill.BackgroundColor = XLColor.FromArgb(183, 222, 232);

					for (int i = 0; i < orderList.Count; i++)
					{
						worksheet.Cell(i + 2, 1).Value = orderList[i].Date;
						worksheet.Cell(i + 2, 2).Value = orderList[i].UpdateTime;
						worksheet.Cell(i + 2, 3).Value = orderList[i].Pair;
						worksheet.Cell(i + 2, 4).Value = orderList[i].Quanity;
						worksheet.Cell(i + 2, 5).Value = orderList[i].Price;
						worksheet.Cell(i + 2, 6).Value = orderList[i].Status;
						worksheet.Cell(i + 2, 7).Value = orderList[i].Type;
						worksheet.Cell(i + 2, 8).Value = orderList[i].Side;
					}

					worksheet.Columns(1, binanceDataDataGridView.ColumnCount).AdjustToContents(12d, 35d);
					workbook.SaveAs(saveFileDialog.FileName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		#endregion

		private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
				ClearData();
			}
		}
		#endregion
	}

	public struct Order
	{
		public DateTime Date { get; set; }
		public DateTime UpdateTime { get; set; }
		public string Pair { get; set; }
		public decimal Quanity { get; set; }
		public decimal Price { get; set; }
		public string Status { get; set; }
		public OrderType Type { get; set; }
		public OrderSide Side { get; set; }
	}
}